using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LoadoutChassis : MonoBehaviour
{
	public int basePayload;
	public int baseAvionics;

    public string defaultSkinName;
    
    public string GetStats()
    {
        return string.Format("Payload: <color=#fec737>{0}</color>\nAvionics: <color=#54b8ff>{1}</color>", basePayload, baseAvionics);
    }
}
