using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conv_attach : MonoBehaviour
{
    private GameObject target;
    public Catch use;
    public float _speed = 1.0f;
    [NonSerialized]
    public bool _conv = false;
    [NonSerialized]
    public bool _readytomove = false;
    void Update()
    {
        if (_readytomove)
        {
            target.transform.Translate(Vector3.forward * _speed * Time.deltaTime);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Target"))
        {
            use._catch = false;
            _conv = true;
            target = other.gameObject;
            target.transform.position = gameObject.transform.position;
            target.transform.rotation = gameObject.transform.rotation;
        }
    }
}
