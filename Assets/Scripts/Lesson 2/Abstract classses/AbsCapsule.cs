using System.Collections;
using System.Collections.Generic;
using Lesson2;
using UnityEngine;



namespace Lessson2
{


    public class AbsCapsule: AbsRotat
    {
        protected override void Rotate()
        {
             transform.rotation=Quaternion.Euler(abstractRotation.x,transform.eulerAngles.y,transform.eulerAngles.z);
        }
    }
}