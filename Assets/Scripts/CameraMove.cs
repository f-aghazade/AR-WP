using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
   private Transform _transformB;
   [SerializeField] private Transform car;
   private Vector3 vec;
  

   private void Awake()
   {
      _transformB = transform;
      vec=_transformB.position-car.position; //bordar bedast miad
   }

   private void Update()
   {
      
      _transformB.position = car.position+vec;
   }
}
