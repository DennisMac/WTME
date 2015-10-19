using UnityEngine;
using System.Collections;

public class ZoomCamera : MonoBehaviour
{

    private float distanceFromTarget;
    public SkinnedMeshRenderer playerMesh;
    public MeshRenderer[] playerItems;

    void Awake()
    {
        distanceFromTarget = transform.localPosition.z;
    }

    void Update()
    {

        if (Input.GetAxis("Mouse ScrollWheel") != 0)
        {
            distanceFromTarget += Input.GetAxis("Mouse ScrollWheel") * 20;
        }

        if (distanceFromTarget != transform.localPosition.z)
        {
            Vector3 temp = transform.localPosition;
            temp.z = Mathf.Lerp(transform.localPosition.z, distanceFromTarget, 5f * Time.deltaTime);
            if (temp.z > 0) temp.z = 0;
            transform.localPosition = temp;
            if (playerMesh != null)//dmc todo: fix this dont want to check every frame
            {
                if (distanceFromTarget > -2)
                {
                    playerMesh.enabled = false;
                    foreach (MeshRenderer mr in playerItems)
                    {
                        mr.enabled = false;
                    }
                }
                else
                {
                    playerMesh.enabled = true;
                    foreach (MeshRenderer mr in playerItems)
                    {
                        mr.enabled = true;
                    }
                }
            }
        }
    }
}
