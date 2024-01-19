using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtualCapsule : VirtualRotation
{
   protected override void RotationObj ()
 {
    transform.rotation=Quaternion.Euler(RotationVals.x,transform.eulerAngles.y,transform.eulerAngles.z);
 }
}
