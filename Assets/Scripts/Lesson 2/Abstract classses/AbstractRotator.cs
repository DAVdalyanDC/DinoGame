using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Lesson2
{
  public abstract class AbsRotat : MonoBehaviour
  {
    [SerializeField] protected Vector3 abstractRotation;

    protected abstract void Rotate();
   
    void Update()
    {
      Rotate();
    }
  }
}