using UnityEngine;
using System.Collections;

public enum AircraftSlot
{
	Any = 0,
	PrimaryWeapon,
	SecondaryWeapon,
	Special,
	Skin,
	AeroMod,
	Gun
}

public enum AircraftClass
{
	Any = 0,
	Fighter,
	Intercetpor,
	Bomber,
	Megabomber,
	Utility
}

namespace SkyRogueModTool
{
    public class CustomAircraftItem : MonoBehaviour
    {
        public int cost = 100;
        public AircraftSlot slot = AircraftSlot.Any;
        public AircraftClass classRestriction = AircraftClass.Any;
        public int payload = 0;
        public int avionics = 0;
    }
}
