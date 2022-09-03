using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class BallFactory : MonoBehaviour
{
    [SerializeField] private Ball _ball;

    public Ball Get()
    {
        Ball instance = Instantiate(_ball);
        return instance;
    }
}
