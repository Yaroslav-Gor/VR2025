using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_anim : MonoBehaviour
{
    public Animator _anim;
    public Renderer button;
    [NonSerialized]
    public bool isActive = false;
    private void OnMouseDown()
    {
        if (!isActive)
        { 
        _anim.SetTrigger("Start");
        button.material.color = new Color32(255, 11, 23, 1);
        isActive = true;
        }
    }
}
