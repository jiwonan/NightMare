using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    public GameObject drop;
    void OnTriggerEnter()
    {
        if (tag == "Drop")
        {
            drop.GetComponent<Rigidbody>().useGravity = true;
        }
    }
}