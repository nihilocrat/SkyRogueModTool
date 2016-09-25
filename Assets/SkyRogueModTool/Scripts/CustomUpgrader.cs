using UnityEngine;
using System.Collections.Generic;

namespace SkyRogueModTool
{
    public enum UpgradeLevels
    {
        MkII,
        MkIII,
        MkIV,
        MkV
    }

    public abstract class CustomUpgrader : MonoBehaviour
    {
        public int level = 1;
        public string upgradePrefabKey;

        //[EnumList(typeof(UpgradeLevels))]
        //public List<UpgradeData> upgradeStats;

        [EnumList(typeof(UpgradeLevels))]
        public List<int> upgradeCosts;
    }
}
