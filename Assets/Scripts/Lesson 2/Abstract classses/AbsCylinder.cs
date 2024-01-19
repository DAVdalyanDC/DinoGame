using System.Collections;
using System.Collections.Generic;
using Lesson2;
using UnityEngine;



namespace Lessson2
{


public class AbsCylinder : AbsRotat
    {
        protected override void Rotate()
        {
            transform.rotation=Quaternion.Euler(abstractRotation); 
        }
    }
}