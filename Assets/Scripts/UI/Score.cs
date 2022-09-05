using FallingBalls.Common;
using TMPro;
using UnityEngine;

namespace FallingBalls.UI
{
    [RequireComponent(typeof(TMP_Text))]
    public class Score : MonoBehaviour
    {
        [SerializeField] private StartButton _startButton;
        private TMP_Text _scoreText;
        private int _value;

        private void Awake()
        {
            _scoreText = GetComponent<TMP_Text>();
        }

        private void OnEnable()
        {
            EventsHolder.Hit += OnHit;
            _startButton.Clicked += OnClicked;
        }

        private void OnHit(int value)
        {
            Debug.Log(value);
            _value += value;
            _scoreText.SetText($"Score: {_value}");
        }

        private void OnClicked()
        {
            _value = 0;
            _scoreText.SetText($"Score: {_value}");
        }

        private void OnDisable()
        {
            EventsHolder.Hit -= OnHit;
        }
    }
}
