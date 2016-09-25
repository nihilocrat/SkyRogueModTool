using UnityEngine;
using System.Collections;

public class PrefabSpawner : MonoBehaviour
{
	public GameObject prefab;

	void Start()
	{
		SpawnPrefab();
	}

	public void SpawnPrefab()
	{
		var obj = Instantiate(prefab, transform.position, transform.rotation) as GameObject;
		
		obj.name = obj.name.Replace("(Clone)","");
		
		obj.transform.parent = transform.parent;
		obj.transform.localScale = transform.localScale;
		
		Destroy(gameObject);
	}
}
