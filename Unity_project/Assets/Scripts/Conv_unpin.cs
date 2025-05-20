using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conv_unpin : MonoBehaviour
{
    public Conv_attach use1;
    public Catch use2;
    public Animator _anim;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Target"))
        { 
            use1._readytomove = false;
            use2._catch = false;
            use1._conv = false;
            _anim.SetTrigger("BeforeDoor");
        }
    }
}
