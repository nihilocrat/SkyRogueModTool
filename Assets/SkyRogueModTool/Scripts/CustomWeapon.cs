using UnityEngine;
using System.Collections;

namespace SkyRogueModTool
{
    public class CustomWeapon : MonoBehaviour
    {
        public GameObject bulletPrefab;
        public int maxClipSize = 5;
        public int maxAmmo = -1;             // if maxAmmo < 0, weapon has infinite ammo
        public float rate = 1.0f;
        public float reloadRate = 0.5f;
        public float accuracy = 0.0f;
        public bool replaceMaterial = true;
        public bool fullClipReload = false;
        public Texture2D targetConeTexture;
        public Texture2D outerTargetConeTexture;
        public GameObject targetConePrefab;
        public GameObject outerTargetConePrefab;
        public Vector3 addedRotation = Vector3.zero;
        public bool isGun = false;
    }
}
