using UnityEngine;
using System.Collections;

[AddComponentMenu("Audio/Audio Randomizer")]
public class AudioRandomizer : MonoBehaviour
{	
	public bool playOnAwake = true;
	public float minVolume = 1.0f;
	public float maxVolume = 1.0f;
	public float minPitch = 1.0f;
	public float maxPitch = 1.0f;
	public AudioClip[] audioClips;

    private AudioSource source;

	void Start ()
	{
        source = GetComponent<AudioSource>();
		Randomize();
		if(playOnAwake)
		{
			source.Play();
		}
	}

	public void Randomize()
	{
		var originalPitch = source.pitch;
		var pitch = (Random.value * (maxPitch - minPitch)) + minPitch;
		source.pitch = pitch;
		
		var originalVolume = source.volume;
		var volume = (Random.value * (maxVolume - minVolume)) + minVolume;
		source.volume = volume;
		
		if(audioClips.Length > 0)
		{
			var index = Random.Range(0, audioClips.Length);
			source.clip = audioClips[index];
		}
	}
	
}
