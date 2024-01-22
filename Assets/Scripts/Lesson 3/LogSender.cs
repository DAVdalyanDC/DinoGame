using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Lesson3;
using UnityEngine;
using UnityEngine.UI;

namespace Lesson3
{
    public class LogSender : MonoBehaviour
    {
        List<ILog> _loggers= new();
        public void Register(ILog logger)
        {
            _loggers.Add(logger);
        }

        float logPerSecond= 0.0f;
        public void Update()
        {
            logPerSecond += Time.deltaTime;
            if (logPerSecond >= 1f) 
            {
                logPerSecond = logPerSecond % 1f;
             
                foreach(ILog log in _loggers)
                {
                    log.Print(log.GetType().Name+DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.ff"));
                }
            }
        }
    }
}