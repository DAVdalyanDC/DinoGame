using System.Collections;
using System.Collections.Generic;
using Lesson3;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UITextLogger : MonoBehaviour, ILog
{
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private LogSender _logSender;
    private string newText;

    public void Print(string log)
    {
        text.text = text.text + "\n" + log;
    }
    void Awake()
    {
        text.text= "";
        _logSender.Register(this);
    }

    
}