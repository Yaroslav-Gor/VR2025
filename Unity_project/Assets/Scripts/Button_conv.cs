using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_conv : MonoBehaviour
{
    public Conv_attach use;
    private void OnMouseDown()
    {
        use._readytomove = true;
    }
}
