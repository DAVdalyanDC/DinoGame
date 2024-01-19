using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lesson2
{


    public class RotationDealer : MonoBehaviour
    {
        [SerializeField] private List<GameObject> objs= new List<GameObject>();

        private List<IRotationDealer> rotationDealers= new List<IRotationDealer>();

        void Awake()
        {
            foreach(var obj in objs)
            {
                rotationDealers.Add(obj.GetComponent<IRotationDealer>());
            }
        }
    
        void Update()
        {
            foreach(var iRotationDealer in rotationDealers)
            {
                iRotationDealer.Rotate();
            }
        }
    }
}