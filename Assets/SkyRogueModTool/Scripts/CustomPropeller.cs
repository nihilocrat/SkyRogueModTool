using UnityEngine;
using System.Collections;

namespace SkyRogueModTool
{
    public class CustomPropeller : MonoBehaviour
    {
        [Tooltip("CAN BE 'NONE'. This is the model which will be shown when the engine is turned off, such as on the carrier menu.")]
        public Transform staticPropMesh;
        [Tooltip("A propeller can change its visualization based on the aircraft's current throttle. This lets you transition from a solid prop to a transparent blur effect. If you want to keep things simple, just define a single prop stage.")]
        public PropellerStage[] stages;
    }
}