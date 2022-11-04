using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ColliderTriggerController : MonoBehaviour
{
    public string collidername;
    public UnityEvent Event1;
    public bool SelfDestruct;
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Printed");
        if(other.transform.name == collidername)
        {
            Event1.Invoke();
            if (SelfDestruct)
            {
                transform.gameObject.SetActive(false);
            }
        }
    }
}
