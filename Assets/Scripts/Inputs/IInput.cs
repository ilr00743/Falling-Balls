using System;
using UnityEngine;

namespace FallingBalls.Inputs
{
    public interface IInput
    {
        public event Action<Vector3> Clicked;
        public void Click();
    }
}
