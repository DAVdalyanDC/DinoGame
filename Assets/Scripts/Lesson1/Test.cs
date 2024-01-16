

using UnityEngine;


namespace Lesson1
{ 
    //ECS Entity Component System
    //COP Component Oriented Programming
     public class Test : MonoBehaviour
     {
      [SerializeField] private int value;

      private void Awake(){
        Debug.Log("Awake");
      }//Ogtagorcvum a yerb runtime sarqvum a componenty
      private void Start(){
        Debug.Log("Start");
      }
      private void Update(){}
      private void OnEnable(){
        Debug.Log("Enable");
      }
      private void OnDisable(){
        Debug.Log("Disable");
      }
      private void OnDestroy(){
        Debug.Log("Destroy");
      }
      private void FixedUpdate(){}
      private void LateUpdate(){}
     }
}