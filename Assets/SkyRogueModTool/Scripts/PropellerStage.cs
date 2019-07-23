using UnityEngine;
using System.Collections;

[System.Serializable]
public class PropellerStage
{
    [Tooltip("The visible component of this prop stage")]
    public Transform propMesh;
    [Tooltip("Throttle at which this prop stage will be chosen. If you want to keep things simple, just define only one prop stage and set this to 0.5.")]
    [Range(0.5f, 1.5f)]
    public float beginThrottle = 0.5f;
    [Tooltip("At minimum throttle, the 'speed' will be multiplied by this amount")]
    [Range(-2f, 2f)]
    public float minSpin = -1f;
    [Tooltip("At maximum throttle, the 'speed' will be multiplied by this amount")]
    [Range(-2f, 2f)]
    public float maxSpin = 0.1f;
    [Tooltip("Base rotation speed of this prop stage")]
    public float speed = 1000f;
}
