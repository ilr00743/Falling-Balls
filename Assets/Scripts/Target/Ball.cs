using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour, ITarget
{
    public void TakeHit()
    {
        Destroy(gameObject);
    }
}
