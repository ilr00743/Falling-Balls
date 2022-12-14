using System.Collections;
using TMPro;
using UnityEngine;

namespace FallingBalls.UI
{
    [RequireComponent(typeof(TMP_Text))]
    public class Timer : MonoBehaviour
    {
        [SerializeField] private StartButton _startButton;
        [SerializeField] private StopButton _stopButton;
        private TMP_Text _timerText;
        private IEnumerator _coroutine;
        private float _currentTime;
        private bool _isActive;

        private void Awake()
        {
            _timerText = GetComponent<TMP_Text>();
        }

        private void Start()
        {
            _coroutine = TimeCountdown();
        }

        private void OnEnable()
        {
            _startButton.Clicked += OnStarted;
            _stopButton.Clicked += OnStopped;
        }

        private void OnDisable()
        {
            _startButton.Clicked -= OnStarted;
        }

        private void OnStarted()
        {
            _currentTime = 0;
            StartCoroutine(_coroutine);
        }

        private void OnStopped()
        {
            StopCoroutine(_coroutine);
        }

        private IEnumerator TimeCountdown()
        {
            while (true)
            {
                _currentTime += Time.deltaTime;
                int seconds = (int)(_currentTime % 60);
                int minutes = (int)(_currentTime / 60) % 60;
                int hours = (int)(_currentTime / 3600) % 24;
            
                _timerText.text = $"Timer: {hours:00}:{minutes:00}:{seconds:00}";
                yield return null;
            }
        }
    }
}
