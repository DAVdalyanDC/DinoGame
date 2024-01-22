using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

namespace Lesson4
{

    public class FileLogger :  AbstractLogger 
    {
        [SerializeField] private LogSender _logSender;
        private string path = Application.dataPath +"/Scripts/Lesson4/Log(1).txt";

        public override void Print(string log)
        {
            log= log + "\n";
            File.AppendAllText(path,log);
        }

        // Start is called before the first frame update
        private void Awake()
        {

            Debug.Log(path);
            if(!File.Exists(path))
            {
                File.Create(path);
            }
            File.WriteAllText(path,"");
            _logSender.Register(this);
        }      
    }
}