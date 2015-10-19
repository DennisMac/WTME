using UnityEngine;
using System.Collections;
using UnitySampleAssets.Cameras;

public class Spawner : MonoBehaviour {

    public GameObject player;
    public FreeLookCam cam;
    private GameObject livePlayer = null;

    void Start()
    {
        SpawnSpaceMan();
    }

    public void SpawnSpaceMan() {
        if (livePlayer != null)
        {
            Destroy(livePlayer.gameObject);
        }

        livePlayer = Instantiate(player, transform.position, transform.rotation) as GameObject;
        livePlayer.SetActive(true);
        cam.SetTarget(livePlayer.transform);
	}
	
    public void SetTransform(Transform trans)
    {
        transform.position = trans.position + 2 * Vector3.up;
        transform.rotation = trans.rotation;
    }

}
