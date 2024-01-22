using System.Collections;
using System.Collections.Generic;
using Lesson3;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Lesson4
{
    public class UITextLogger : AbstractLogger 
    {
        [SerializeField] private TextMeshProUGUI text;
        [SerializeField] private LogSender _logSender;
        private string newText;

        public override void Print(string log)
        {
            text.text = text.text + "\n" + log;
        }
        void Awake()
        {
            text.text= "";
            _logSender.Register(this);
        }

        
    }
}