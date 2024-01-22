using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Lesson4
{
    public class LogSender : MonoBehaviour
    {
        List<AbstractLogger > _loggers= new();
        public void Register(AbstractLogger  logger)
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
             
                foreach(AbstractLogger log in _loggers)
                {
                    log.Print(log.GetType().Name+DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.ff"));
                }
            }
        }
    }
}