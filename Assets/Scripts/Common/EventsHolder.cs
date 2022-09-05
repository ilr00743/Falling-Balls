using System;
using UnityEngine;

namespace FallingBalls.Common
{
    public class EventsHolder : MonoBehaviour
    {
        public static event Action<int> Hit;
        public static event Action StopClicked;
        
        public static void SendTargetHit(int value)
        {
            Hit?.Invoke(value);
        }

        public static void SendStopClicked()
        {
            StopClicked?.Invoke();
        }
    }
}
