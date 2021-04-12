using OpcAlarmServer.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace OpcAlarmServer
{
    class ScriptEngine
    {
        public delegate void NextScriptStepAvailable(Step step, long numberOfLoops);
        public NextScriptStepAvailable OnNextScriptStepAvailable;

        private LinkedList<Step> _steps;
        private LinkedListNode<Step> _currentStep;
        private Timer _stepsTimer;
        private Script _script;
        private long _numberOfLoops = 1;
        private DateTime _scriptStartTime;

        /// <summary>
        /// Initialize ScriptEngine
        /// </summary>
        /// <param name="script"></param>
        /// <param name="scripCallback"></param>
        public ScriptEngine(Script script, NextScriptStepAvailable scripCallback)
        {
            OnNextScriptStepAvailable += scripCallback;

            _script = script;

            CreateLinkedList(script.Steps);

            StartScript();
        }

        private void StartScript()
        {
            _stepsTimer = new Timer();
            _stepsTimer.Elapsed += OnStepTimedEvent;
            _stepsTimer.Interval = _script.WaitUntilStartInSeconds * 1000;
            _stepsTimer.Start();
            _scriptStartTime = DateTime.Now;
        }

        private void StopScript()
        {
            _stepsTimer.Close();
            _stepsTimer = null;
        }

        /// <summary>
        /// Create the Linked List that will be used internally to go through the steps
        /// </summary>
        /// <param name="steps"></param>
        private void CreateLinkedList(List<Step> steps)
        {
            _steps = new LinkedList<Step>();
            foreach (var step in steps)
            {
                _steps.AddLast(step);
            }
        }

        /// <summary>
        /// Active a new step
        /// </summary>
        /// <param name="step"></param>
        private void ActivateCurrentStep(LinkedListNode<Step> step)
        {
            _currentStep = step;
            OnNextScriptStepAvailable!.Invoke(step?.Value , _numberOfLoops);
            if (_stepsTimer != null)
            {
                _stepsTimer.Interval = 1 + step.Value.SleepInSeconds * 1000;
            }
        }

        /// <summary>
        /// Get the next step
        /// </summary>
        /// <param name="step"></param>
        /// <returns></returns>
        private LinkedListNode<Step> GetNextValue(LinkedListNode<Step> step)
        {
            if(_scriptStartTime.AddSeconds(_script.RunningForSeconds) < DateTime.Now)
            {
                StopScript();
                return null;
            }

            if(step == null)
            {
                return _steps.First;
            }
            else
            {
                if(step!.Next != null)
                {
                    return step!.Next;
                }
                else
                {
                    if (_script.StepsInLoop)
                    {
                        _numberOfLoops++;
                        return _steps.First;
                    }
                    else
                    {
                        StopScript();
                        return null;
                    }
                }
            }
        }

        /// <summary>
        /// Trigger when next step should be executed
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private void OnStepTimedEvent(Object source, ElapsedEventArgs e)
        {
            ActivateCurrentStep(GetNextValue(_currentStep));
        }
    }
}
