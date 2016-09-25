using UnityEngine;

[System.Serializable]
public class DeathFXSettings
{
    public GameObject boomPrefab;
    public int extraBooms = 0;
    public GameObject trailPrefab;
    public int extraTrails = 0;
    /*
    public void AddFX(Transform transform)
    {
        var gameObject = transform.gameObject;

        // main boom
        // no null check: death FX without a boom is ridiculous and should throw an error
        GameObject.Instantiate(boomPrefab, transform.position, transform.rotation);

        // main trail
        if (trailPrefab != null)
        {
            var damage = GameObject.Instantiate(trailPrefab, transform.position, transform.rotation) as GameObject;
            damage.transform.SetParent(transform);
        }

        if (extraBooms > 0)
        {
            var meshFilter = transform.GetComponentInChildren<MeshFilter>();
            if (meshFilter)
            {
                var booms = gameObject.AddComponent<BoomSpawner>();
                booms.prefab = boomPrefab;
                booms.sourceMesh = meshFilter.sharedMesh;
                booms.attachBooms = false;
                booms.OnKill();
            }
        }

        if (extraTrails > 0)
        {
            var meshFilter = transform.GetComponentInChildren<MeshFilter>();
            if (meshFilter)
            {
                var booms = gameObject.AddComponent<BoomSpawner>();
                booms.prefab = trailPrefab;
                booms.sourceMesh = meshFilter.sharedMesh;
                booms.attachBooms = true;
                booms.OnKill();
            }
        }
    }
    */
}
