using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catch : MonoBehaviour
{
    [NonSerialized]
    public bool _catch = false;
    private GameObject target;
    public Conv_attach use1;
    public Stanok_attach use2;

    void Update()
    {
        if (_catch && !use1._conv && !use2._instanok)
        {
            target.transform.position = gameObject.transform.position; 
            target.transform.rotation = gameObject.transform.rotation;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Target"))
        {
            _catch = true;
            target = other.gameObject;
        }
    }
}