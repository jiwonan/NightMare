using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Endding : MonoBehaviour
{
    void OnTriggerEnter()
    {
        if (tag == "start")
        {
            SceneManager.LoadScene("Endding");
        }
        else if (tag == "quit")
        {
            Application.Quit();
        }
    }
}