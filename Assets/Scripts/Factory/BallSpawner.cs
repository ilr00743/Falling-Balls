using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField] private BallFactory _ballFactory;
    [SerializeField] private ScreenBounds _screenBounds;
    [SerializeField, Range(1, 10)] private float _spawnInterval;

    private IEnumerator _coroutine;

    private void Start()
    {
        _screenBounds.Init();
        _coroutine = Spawn();
        StartCoroutine(_coroutine);
    }

    private void StartSpawn()
    {
        StartCoroutine(_coroutine);
    }

    private void StopSpawn()
    {
        StopCoroutine(_coroutine);
    }

    private IEnumerator Spawn()
    {
        while (true)
        {
            Ball ball;
            ball = _ballFactory.Get();
            ball.SpawnTo(_screenBounds);
            yield return new WaitForSeconds(_spawnInterval);
        }
    }
}
