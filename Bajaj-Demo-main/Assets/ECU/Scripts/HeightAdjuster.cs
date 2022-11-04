using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeightAdjuster : MonoBehaviour
{
    // Start is called before the first frame update
    public float wantedPlayerHeight;
    public GameObject mainCamera;
    void Start()
    {
         var mixedRealityPlayspace = GameObject.FindGameObjectsWithTag("Player")[0].transform;
         var camHeight = mainCamera.transform.position.y;
         var adjustement =wantedPlayerHeight-camHeight ;
         mixedRealityPlayspace.position= new Vector3(mixedRealityPlayspace.position.x,mixedRealityPlayspace.position.y+adjustement, mixedRealityPlayspace.position.z);
    }
}
