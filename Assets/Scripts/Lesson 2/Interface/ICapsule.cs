using System.Collections;
using System.Collections.Generic;
using Lesson2;
using UnityEngine;

public class ICapsule : MonoBehaviour, IRotationDealer
{
   [SerializeField] private Vector3 ObjRotator;
    public void Rotate()
    {
        transform.rotation= Quaternion.Euler(transform.eulerAngles.x,transform.eulerAngles.y,ObjRotator.z);
    }
}

