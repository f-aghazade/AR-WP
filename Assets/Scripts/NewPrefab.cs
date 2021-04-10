using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.VR;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using Random = UnityEngine.Random;

public class NewPrefab : MonoBehaviour
{
   [SerializeField] private GameObject PrefabInstance;
   private float _time;
   private Transform _transform;
   private Vector3 vec, lastPos;

   private void Awake()
   {
      _transform = transform;
      lastPos = _transform.position;
   }

   private void Update()
   {
      _time += Time.deltaTime;
      if(_time<2) return;
      _time = 0;
      
      vec = transform.position - lastPos;

      var newG=Instantiate(PrefabInstance,PrefabInstance.transform.position+vec,Quaternion.identity,transform);

      lastPos = transform.position;
   }


}
