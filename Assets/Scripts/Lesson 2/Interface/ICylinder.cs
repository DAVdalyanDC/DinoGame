using System.Collections;
using System.Collections.Generic;
using Lesson2;
using UnityEngine;

public class ICylinder : MonoBehaviour, IRotationDealer
{
    [SerializeField] private Vector3 ObjRotator;
    public void Rotate()
    {
        transform.rotation= Quaternion.Euler(ObjRotator.x,transform.eulerAngles.y,transform.eulerAngles.z);
    }
}
