using UnityEngine;
using System.Collections;

namespace SkyRogueModTool
{
    public class CustomDestroyable : MonoBehaviour
    {
        public int hitPoints = 100;
        public GameObject boom;
        public bool destroyOnKill = true;
        public bool shatterOnKill = false;
        public bool extraBooms = false;
        public bool dontUseTeamMaterial = false;
        public bool dontHurtCollidingVehicles = false;
        public bool hidden = false;
    }
}
