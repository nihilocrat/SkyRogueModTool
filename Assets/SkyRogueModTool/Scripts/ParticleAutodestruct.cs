using UnityEngine;
using System.Collections;

[RequireComponent(typeof(ParticleSystem))]
public class ParticleAutodestruct : MonoBehaviour
{
	void Start ()
	{
        var particleSystem = GetComponent<ParticleSystem>();
        if (!particleSystem.loop)
		{
			Destroy(gameObject, particleSystem.duration);
		}
	}
    
	public void DestroyGracefully()
	{
		DestroyGracefully(gameObject);
	}
	
	public static void DestroyGracefully(GameObject go)
	{
		go.transform.parent = null;
		go.GetComponent<ParticleSystem>().loop = false;
		go.GetComponent<ParticleSystem>().enableEmission = false;
		Destroy(go, go.GetComponent<ParticleSystem>().duration);
	}
}
