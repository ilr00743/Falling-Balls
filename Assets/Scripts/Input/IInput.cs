using System;
using UnityEngine;

namespace Input
{
    public interface IInput
    {
        public event Action<Vector3> Clicked;
        public void Click();
    }
}
