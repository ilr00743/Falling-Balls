using UnityEngine;

namespace FallingBalls.Target
{
    [RequireComponent(typeof(MeshRenderer))]
    public class BallView : MonoBehaviour
    {
        private MeshRenderer _meshRenderer;

        private void Awake()
        {
            _meshRenderer = GetComponent<MeshRenderer>();
        }

        public void Init(Color color)
        {
            _meshRenderer.material.color = color;
        }
    }
}
