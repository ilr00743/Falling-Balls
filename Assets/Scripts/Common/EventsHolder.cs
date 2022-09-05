using System;
using UnityEngine;

namespace FallingBalls.Common
{
    public class EventsHolder : MonoBehaviour
    {
        public static event Action<int> Hit; 
        public static void SendTargetHit(int value)
        {
            Hit?.Invoke(value);
        }
    }
}
