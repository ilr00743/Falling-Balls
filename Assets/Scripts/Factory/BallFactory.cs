using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Data;
using UnityEngine;

[CreateAssetMenu(fileName = "BallFactory", menuName = "Ball/Factory", order = 0)]
public class BallFactory : ScriptableObject
{
    [SerializeField] Ball _ball;
    [SerializeField] private BallPropertiesGenerator _propertiesGenerator;

    public Ball Get()
    {
        Ball instance = Instantiate(_ball);
        BallProperties ballProperties = _propertiesGenerator.Get();
        instance.Init(ballProperties);
        return instance;
    }
}
