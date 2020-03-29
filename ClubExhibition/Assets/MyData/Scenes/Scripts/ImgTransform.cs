using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImgTransform : MonoBehaviour
{
    public GameObject on;
    public GameObject off;

    void OnTriggerStay()
    {
        if (tag == "Enemy")
        {
            on.gameObject.SetActive(true);
            off.gameObject.SetActive(false);
        }
        else if(tag == "End")
        {
            on.gameObject.SetActive(false);
            off.gameObject.SetActive(true);
        }
    }
}
