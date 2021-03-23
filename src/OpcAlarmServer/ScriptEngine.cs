using OpcAlarmServer.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace OpcAlarmServer
{
    class ScriptEngine
    {
        public delegate void NextScriptStepAvailable(Step step);
        public NextScriptStepAvailable OnNextScriptStepAvailable;

        private LinkedList<Step> _steps;
        private LinkedListNode<Step> _currentStep;
        private Timer _stepsTimer;
        private Script _script;

        public ScriptEngine(Script script, NextScriptStepAvailable scripCallback)
        {
            OnNextScriptStepAvailable += scripCallback;

            _script = script;

            CreateLinkedList(script.Steps);

            _stepsTimer = new Timer();
            _stepsTimer.Elapsed += OnStepTimedEvent;
            _stepsTimer.Interval = _script.WaitUntilStartInSeconds * 1000;
            _stepsTimer.Start();
        }

        private void CreateLinkedList(List<Step> steps)
        {
            _steps = new LinkedList<Step>();
            foreach (var step in steps)
            {
                _steps.AddLast(step);
            }
        }

        private void ActivateCurrentStep(LinkedListNode<Step> step)
        {
            _currentStep = step;
            OnNextScriptStepAvailable!.Invoke(step.Value);
           _stepsTimer.Interval = 1 + step.Value.SleepInSeconds * 1000;
        }

        private LinkedListNode<Step> GetNextValue(LinkedListNode<Step> step)
        {
            if(step == null)
            {
                return _steps.First;
            }

            return step!.Next ?? _steps.First;
        }

        private void OnStepTimedEvent(Object source, ElapsedEventArgs e)
        {
            ActivateCurrentStep(GetNextValue(_currentStep));
        }
    }
}
