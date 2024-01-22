using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

namespace Lesson3 
{

    public class FileLogger : MonoBehaviour, ILog
    {
        [SerializeField] private LogSender _logSender;
        private string path = Application.dataPath +"/Scripts/Lesson 3/Log.txt";

        public void Print(string log)
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