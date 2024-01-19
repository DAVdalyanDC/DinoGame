using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtualCylinder : VirtualRotation
{
   

    protected override void RotationObj ()
 {
    transform.rotation=Quaternion.Euler(transform.eulerAngles.x,RotationVals.y,transform.eulerAngles.z);
 }


}
