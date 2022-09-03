using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    private IInput _input;
    // Start is called before the first frame update
    void Start()
    {
#if UNITY_STANDALONE
        _input = new MouseInput();
#endif
#if UNITY_IOS || UNITY_ANDROID
        _input = new MobileInput();
#endif
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
