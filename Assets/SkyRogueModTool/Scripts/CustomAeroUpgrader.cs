﻿using UnityEngine;
using System.Collections.Generic;

namespace SkyRogueModTool
{
    [RequireComponent(typeof(CustomAirfoil))]
    public class CustomAeroUpgrader : CustomUpgrader
    {
        //[EnumList(typeof(UpgradeLevels))]
        public List<CustomAeroData> aeroUpgradeStats;
    }

    [System.Serializable]
    public class CustomAeroData
    {
        public float maxThrust;
        public float throttleChangeSpeed;
        public Vector3 yprSpeed;

        public int hitPoints;
    }

}
