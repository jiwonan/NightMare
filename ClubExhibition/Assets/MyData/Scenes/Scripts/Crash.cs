using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crash : MonoBehaviour
{
    public GameObject teacher;

    void OnTriggerStay()
    {
        if (tag == "Enemy")
        {
            teacher.gameObject.SetActive(true);
        }
        else if (tag == "End")
        {
            teacher.gameObject.SetActive(false);
        }
    }
}