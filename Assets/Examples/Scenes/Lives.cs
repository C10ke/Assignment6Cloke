using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Lives : MonoBehaviour
{
    
    private int lives = 3;    
    public Text livesText;

    private void OnTriggerEnter(Collider other)
    {        

        if (other.gameObject.tag == "Player")
        {
            Debug.Log("player hit");
            lives -= 1;
            livesText.text = "Lives: " + lives.ToString();
            if (lives == 0)
            {
                SceneManager.LoadScene("1_multiple_agent_sizes");
            }

        }

    }
    

}