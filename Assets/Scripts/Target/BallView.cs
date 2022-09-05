using UnityEngine;

namespace Target
{
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
