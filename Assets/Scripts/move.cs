using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
   [SerializeField] private Transform _transformB;
   private Transform _transform;
   [SerializeField] private float speed;
   private Vector3 vec;

   private void Awake()
   {
      _transform = transform;
      
   }

   private void OnEnable()
   {
      print("onEnable");
   }

   private void Start()
   {
      print("start");
      var newGO = new GameObject("Porsche");
      
      var moveCO = newGO.AddComponent<move>();
     
   }

   private void Update()
   {
      
     // _transform.localPosition = _transform.localPosition + new Vector3( 0, 0,speed -0.1f- Time.deltaTime);//bordare jabejayi bayad baraye z bedast biad
      
      //  _transform.localScale = Vector3.right * Time.deltaTime;


   }
}
