using UnityEngine;
using System.Collections;

namespace SkyRogueModTool
{
    [RequireComponent(typeof(CustomAirfoil))]
    public class CustomSwingWing : MonoBehaviour
    {
        public Transform wingRight;
        public Transform wingLeft;
        public Transform engineSection;
        public float minWingSwing = 0f;
        public float maxWingSwing = 35f;
        public float maxWingPush = 0f;
        public float maxEnginePush = -0.05f;
    }
}