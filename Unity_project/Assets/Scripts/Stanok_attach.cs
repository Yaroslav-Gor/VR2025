using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stanok_attach : MonoBehaviour
{
    public Catch use;
    private GameObject target;
    [NonSerialized]
    public bool _instanok = false;
    void Update()
    {
        if (_instanok)
        {
            target.transform.position = gameObject.transform.position;
            target.transform.rotation = gameObject.transform.rotation;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Target"))
        {
            target = other.gameObject;
            _instanok = true;
        }
    }
}
