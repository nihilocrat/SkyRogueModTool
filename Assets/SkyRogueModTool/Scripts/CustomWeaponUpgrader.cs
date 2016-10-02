using UnityEngine;
using System.Collections.Generic;

namespace SkyRogueModTool
{
    [RequireComponent(typeof(CustomWeapon))]
    public class CustomWeaponUpgrader : CustomUpgrader
    {
        [EnumList(typeof(UpgradeLevels))]
        public List<CustomWeaponData> upgradeStats;
    }

    [System.Serializable]
    public class CustomWeaponData
    {
        // weapon
        public int maxClipSize = 0;
        public int maxAmmo = 0;
        public float rate = 0f;
        public float reloadRate = 0f;
        public float accuracy = 0f;

        // bullet
        public int damage;
        public int range;
        public float speed;
        public int mirvCount;

        // guided missile settings
        public float targetCone;
    }
}
