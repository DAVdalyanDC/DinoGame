using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace Lesson4
{
    public class ConsoleLogger : AbstractLogger 
    {
        [SerializeField] private LogSender _logSender;
        public override void Print(string textToLog)
        {
            Debug.Log(textToLog);
        }

        public void Awake()
        {
            _logSender.Register(this);

        }
    }
}