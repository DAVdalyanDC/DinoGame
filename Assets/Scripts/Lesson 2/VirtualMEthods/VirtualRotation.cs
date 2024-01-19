using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtualRotation : MonoBehaviour
{
    [SerializeField] protected Vector3 RotationVals;
    protected virtual void RotationObj()
    {
        transform.rotation = Quaternion.Euler(RotationVals);
        
    }
        void Update()
        {
            RotationObj();
        }
    
}
