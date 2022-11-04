using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfTurnOff : MonoBehaviour
{
    public void SelfDestruct ()
    {
        transform.gameObject.SetActive(false);
    }
}
