using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


namespace Lessson2
{


    public class RotationScript : MonoBehaviour
    {

        [SerializeField] protected Vector3 RotationVals;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
           transform.rotation=Quaternion.Euler(RotationVals);

        }
    }
}