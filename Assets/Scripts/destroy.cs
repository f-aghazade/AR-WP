using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    private float _time;

    private void Update()
    {
        _time += Time.deltaTime;
        if(_time<2) return;
        _time = 0;
        Destroy(gameObject);
    }
}