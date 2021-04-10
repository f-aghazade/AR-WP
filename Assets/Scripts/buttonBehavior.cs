using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class buttonBehavior : MonoBehaviour
{
  // [SerializeField] private bool inAdditive;
  // [SerializeField] private string sceneName;
  //
  // private void Start()
  // {
  //   var isAdditive = inAdditive ? LoadSceneMode.Additive : LoadSceneMode.Single;
  //   SceneManager.LoadScene(sceneName, isAdditive);
  // }
  
  public void LoadSceneOnClick(int sceneNo)
  {
    SceneManager.LoadScene(1);
  }
}
