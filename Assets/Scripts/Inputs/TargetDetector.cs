using FallingBalls.Target;
using UnityEngine;

namespace FallingBalls.Inputs
{
    public class TargetDetector : MonoBehaviour
    {
        private IInput _input;
        private Camera _camera;

        private void Awake()
        {
#if UNITY_ANDROID
            _input = new MobileInput();
#endif
#if UNITY_STANDALONE || UNITY_EDITOR
            _input = new MouseInput();
#endif
            _camera = Camera.main;
        }

        private void OnEnable()
        {
            _input.Clicked += OnClicked;
        }

        private void Update()
        {
            _input.Click();
        }

        private void OnClicked(Vector3 position)
        {
            Ray ray = _camera.ScreenPointToRay(position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.TryGetComponent<ITarget>(out var target))
                {
                    target.TakeHit();
                }
            }
        }
    }
}
