using System;
using System.Collections;
using FallingBalls.Target;
using FallingBalls.UI;
using UnityEngine;

namespace FallingBalls.Factory
{
    public class BallSpawner : MonoBehaviour
    {
        [SerializeField] private BallFactory _ballFactory;
        [SerializeField] private ScreenBounds _screenBounds;
        [SerializeField] private StartButton _startButton;
        [SerializeField] private StopButton _stopButton;
        
        [SerializeField, Range(1, 10)] private float _spawnInterval;

        private IEnumerator _coroutine;

        private void OnEnable()
        {
            _startButton.Clicked += OnStartClicked;
            _stopButton.Clicked += OnStopClicked;
        }

        private void Start()
        {
            _screenBounds.Init();
            _coroutine = Spawn();
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

        private void OnStartClicked()
        {
            StartSpawn();
        }

        private void OnStopClicked()
        {
            StopSpawn();
        }
    }
}
