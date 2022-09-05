using FallingBalls.Common;
using FallingBalls.Data;
using FallingBalls.UI;
using UnityEngine;

namespace FallingBalls.Target
{
    public class Ball : MonoBehaviour, ITarget
    {
        [SerializeField] private int _rewardPointsMultiplier;
        private BallView _ballView;
        private float _speed;
        private int _rewardPoints;
        private float _bottomBorder;

        private void Awake()
        {
            _ballView = GetComponent<BallView>();
        }

        public void Init(BallProperties properties)
        {
            transform.localScale = new Vector3(properties.Size, properties.Size, properties.Size);
            _speed = properties.Speed / properties.Size;
            _rewardPoints =  Mathf.RoundToInt(_speed / properties.RewardPoints * _rewardPointsMultiplier);
            _ballView.Init(properties.Color);
        }

        private void Update()
        { 
            transform.Translate(Vector3.down * (_speed * Time.deltaTime));

            if (transform.position.y < _bottomBorder)
            {
                GetToBottom();
            }
            // transform.position += Vector3.down * _speed / transform.localScale.x * Time.deltaTime;
        }

        public void SpawnTo(ScreenBounds screenBounds)
        {
            transform.position = screenBounds.GetRandomTopPoint();
            _bottomBorder = screenBounds.BottomBorder;
        }

        private void GetToBottom()
        {
            Destroy(gameObject);
        }
    
        public void TakeHit()
        {
            EventsHolder.SendTargetHit(Mathf.FloorToInt(_rewardPoints));
            Destroy(gameObject);
        }
    }
}
