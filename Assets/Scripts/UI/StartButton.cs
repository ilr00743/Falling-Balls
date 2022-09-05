using System;
using UnityEngine;
using UnityEngine.UI;

namespace FallingBalls.UI
{
    [RequireComponent(typeof(Button))]
    public class StartButton : MonoBehaviour
    {
        [SerializeField] private StopButton _stopButton;
        private Button _button;
        public event Action Clicked;

        private void Awake()
        {
            _button = GetComponent<Button>();
        }

        private void OnEnable()
        {
            _button.onClick.AddListener(OnButtonClicked);
            _stopButton.Clicked += OnStopButtonClicked;
        }

        private void OnStopButtonClicked()
        {
            _button.interactable = true;
        }

        private void OnButtonClicked()
        {
            _button.interactable = false;
            Clicked?.Invoke();
        }

        private void OnDisable()
        {
            _button.onClick.RemoveListener(OnButtonClicked);
            _stopButton.Clicked -= OnStopButtonClicked;
        }
    }
}
