using UnityEngine;
using System.Collections;

namespace SkyRogueModTool
{
    public class CustomAirfoil : MonoBehaviour
    {
        [Header("Primary Stats")]
        public float maxThrust = 1000.0f;
        //public float acceleration = 0.2f;
        public float throttleChangeSpeed = 0.5f;
        public float maxSpeed = 100.0f;
        public float stallAirspeed = 10.0f;
        [Header("Secondary Stats")]
        public float bankSpeed = 1.0f;
        public float wingArea = 15.0f;
        public float baseDrag = 1.0f;
        public float climbPerformance = 3.0f;
        public float divePerformance = 1.5f;
        public float dragCoefficient = 0.05f;
        public float ceiling = 2000.0f;
        public Vector3 yprSpeed = Vector3.one;
        public float throttleYprScalar = 0.5f;
        [Header("Audiovisual Objects")]
        public Transform[] afterburnerTrails;
        public Transform airbrake;
        public Transform airbrakeHinge;
        public AudioSource engineAudio;
        public AudioSource engineAudioHigh;
        [Header("Animated flight surfaces")]
        public float rudderMaxAngle = 30f;
        public Transform[] rudders;
        public float elevonMaxAngle = 45f;
        public Transform[] leftElevons;
        public Transform[] rightElevons;
    }
}
