using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace Lesson3
{
    public class ConsoleLogger : MonoBehaviour, ILog
    {
        [SerializeField] private LogSender _logSender;
        public void Print(string textToLog)
        {
            Debug.Log(textToLog);
        }

        public void Awake()
        {
            _logSender.Register(this);

        }
    }
}