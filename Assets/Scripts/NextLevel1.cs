using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel1 : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {

            SceneManager.LoadScene(2);

        }

    }

}
