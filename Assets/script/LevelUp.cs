using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelUp : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Character")
        {
            SceneManager.LoadScene(2);
        }
    }
}
