using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Prize : MonoBehaviour
{
    private int score = 0;
    
    public Text scoreText;
    

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("got prize");
        if (other.gameObject.tag == "Prize")
        {
            Debug.Log("got prize");
            other.gameObject.SetActive(false);
            score += 10;
            scoreText.text = "Score: " + score.ToString();
        }

       

    }
        

}
