using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractLogger : MonoBehaviour
{
     
        [SerializeField] protected string inspectorLogMes;

        public abstract void Print (string log);
    
}
