using UnityEngine;
using System.Collections;

public class CustomBullet : MonoBehaviour
{
    public GameObject boomPrefab;
    public int team = 0;
    public int damage = 100;
    public float speed = 100.0f;
    public float range = 1000.0f;
    public float drift = 0.0f;
    public float ignitionDelay = 0.0f;
    public float accelerationDelay = 0.0f;
    public float triggerDelay = 0.0f;
    public bool continuousForce = false;
    public bool penetrates = false;
    public bool aoe = false;
    public bool multiplyDriftByRecentMotion = false;
    public float recentMotionDriftMultiplier = 1f;
    public bool onlyBoomOnHit = false;
    public Vector3 manualVelocity;
    public AudioClip releaseSound;
}
