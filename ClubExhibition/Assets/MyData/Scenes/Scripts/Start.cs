using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    void OnTriggerEnter()
    {
        SceneManager.LoadScene("01");
    }
}
