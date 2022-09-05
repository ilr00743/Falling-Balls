using System.Collections.Generic;
using UnityEngine;
using Color = UnityEngine.Color;

namespace FallingBalls.Data
{
    [CreateAssetMenu(fileName = "BallPropertiesGenerator", menuName = "Ball/PropertiesGenerator", order = 0)]
    public class BallPropertiesGenerator : ScriptableObject
    {
        [SerializeField] private List<Color> _colors;
        [SerializeField, Range(0.65f, 2f)] private float _minSize, _maxSize;
        [SerializeField, Range(5, 20)] private float _averageSpeed ;
        [SerializeField] private int _rewardPoints = 50;

        public BallProperties Get()
        {
            var ballProperties = new BallProperties()
            {
                Color = _colors[Random.Range(0, _colors.Count)],
                Size = Random.Range(_minSize, _maxSize),
                Speed = _averageSpeed,
                RewardPoints = _rewardPoints
            };

            return ballProperties;
        }
    }
}