using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTryAgain : MonoBehaviour
{
    public GameObject Prefab;
    GameObject Parent;
    public void SpawmTryAgain()
    {
        Parent = GameObject.FindGameObjectWithTag("Player");
        Instantiate(Prefab, transform.position, transform.rotation, Parent.transform);
        transform.gameObject.SetActive(false);
    }
}
