using System;
using FallingBalls.Common;
using UnityEngine;
using UnityEngine.UI;

namespace FallingBalls.UI
{
    [RequireComponent(typeof(Button))]
    public class StopButton : MonoBehaviour
    {
        private Button _button;
        public event Action Clicked;

        private void Awake()
        {
            _button = GetComponent<Button>();
        }

        private void OnEnable()
        {
            _button.onClick.AddListener(OnButtonClicked);
        }

        private void OnButtonClicked()
        {
            Clicked?.Invoke();
            EventsHolder.SendStopClicked();
        }

        private void OnDisable()
        {
            _button.onClick.RemoveListener(OnButtonClicked);
        }
    }
}
