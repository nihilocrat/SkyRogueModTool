using UnityEngine;
using System.Collections.Generic;

namespace SkyRogueModTool
{
    [RequireComponent(typeof(CustomWeapon))]
    public class CustomMIRVSpawner : MonoBehaviour
    {
        public float delay = 1f;
        public float proximity = 0f;
        public GameObject effectPrefab;
        public bool roundRobinTargets = false;
    }
}