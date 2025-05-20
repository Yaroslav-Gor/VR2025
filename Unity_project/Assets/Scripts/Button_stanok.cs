using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_stanok : MonoBehaviour
{
    public Animator _anim;
    public Animator _anim_arm;

    private void OnMouseDown()
    {
        _anim.SetTrigger("Open");
        _anim_arm.SetTrigger("Ready");
    }
}