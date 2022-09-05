using UnityEngine;

namespace UI
{
    public class ScreenBounds : MonoBehaviour
    {
        [SerializeField] private float _padding;
        private Camera _camera;
        private float _topBorder, _rightBorder, _bottomBorder, _leftBorder;

        public float BottomBorder => _bottomBorder;

        public void Init()
        {
            _camera = Camera.main;
            _topBorder = _camera.ScreenToWorldPoint(
                new Vector3(0, _camera.pixelHeight, Mathf.Abs(_camera.transform.position.z))).y;
            _rightBorder = _camera.ScreenToWorldPoint(
                new Vector3(_camera.pixelWidth, 0, Mathf.Abs(_camera.transform.position.z))).x - _padding;
            _bottomBorder = _camera.ScreenToWorldPoint(
                new Vector3(0, 0, Mathf.Abs(_camera.transform.position.z))).y;
            _leftBorder = _camera.ScreenToWorldPoint(
                new Vector3(0, 0, Mathf.Abs(_camera.transform.position.z))).x + _padding;
        }
    
        public Vector3 GetRandomTopPoint()
        {
            return new Vector3(Random.Range(_leftBorder, _rightBorder), _topBorder, 0);
        }
    }
}
