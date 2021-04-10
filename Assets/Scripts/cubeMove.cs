using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeMove : MonoBehaviour
{
   private Vector3 vec;
   [SerializeField] private GameObject car;
   private Transform _transform;
   [SerializeField] private float speed;
   private Vector3 jump = new Vector3(0, 6f, 0);
   private Vector3 unjump = new Vector3(0, 0, 0);

   private void Awake()
   {
      _transform = car.transform;
   }


   private void Update()
   {
      // vec = transform.localPosition;
      // vec.x = Input.GetAxis("Jump") * Time.deltaTime * 20;
      
      if(Input.GetKey(KeyCode.UpArrow)) 
         _transform.localPosition = _transform.localPosition + new Vector3( 0, 0, speed*(-Time.deltaTime));
      if(Input.GetKey(KeyCode.DownArrow))
         _transform.localPosition = _transform.localPosition + new Vector3( 0, 0,-( speed*(-Time.deltaTime)));
      if(Input.GetKey((KeyCode.LeftArrow)))
         transform.Translate(Vector3.right*0.2f);
      if(Input.GetKey(KeyCode.RightArrow))
         transform.Translate(Vector3.left*0.2f);
      if (Input.GetKey(KeyCode.Space))
      {
         transform.Translate(jump);
         transform.Translate(unjump);
      }
         
   }
}
