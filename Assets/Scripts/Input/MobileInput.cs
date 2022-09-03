using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileInput : IInput
{
    public event Action<Vector3> Clicked;

    public void Click()
    {
        if (Input.touchCount > 0)
        {
            var touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                Clicked?.Invoke(touch.position);
            }
        }
    }
}