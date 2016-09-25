using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public enum GuidanceMethod
{
    None = 0,
    FireAndForget, // missile is given a target and guides itself
    SemiActive,    // owner needs to maintain radar contact with the target
    Infared,       // missile is given a target and guides itself, but only locks on when behind the target
    AntiRadar,	   // missile can find target itself; will lock onto the closest enemy active radar signature
    Camera,        // guided with the right stick
    CameraMark     // guided towards camera look target at launch time (doesn't guide in realtime)
}

public enum GuidanceAspect
{
    None = 0,
    Air,
    Ground,
    Both
}

namespace SkyRogueModTool
{
    public class CustomGuidedMissile : MonoBehaviour
    {
        public GuidanceMethod guidance = GuidanceMethod.FireAndForget;
        public GuidanceAspect aspect = GuidanceAspect.Both;
        public float maxTurnSpeed = 1.0f;
        public float turnWarmupTime = 0.0f;
        public float targettingCone = 30.0f;
        public float lockOnSpeed = 30.0f;
        public float wander = 0.0f;
        public bool autoLock = false;                   // missiles automatically lock on to the closest target, necessary for MIRVs
        public bool dontKillWhenLostTarget = false;     // important for guided bombs
    }
}
