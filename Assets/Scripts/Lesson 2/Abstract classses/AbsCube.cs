using System.Collections;
using System.Collections.Generic;
using Lesson2;
using UnityEngine;



namespace Lessson2
{


    public class AbsCube: AbsRotat
    {
        protected override void Rotate()
        {
            transform.rotation=Quaternion.Euler(transform.eulerAngles.x,abstractRotation.y,transform.eulerAngles.z);
        }
    }
}