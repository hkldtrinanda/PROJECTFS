using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class doorScript : MonoBehaviour
{
    public GameObject endPanel;
    public GameObject uiToDisable1;
    public GameObject uiToDisable2;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            other.GetComponent<WalkingSimulator>().enabled = false;
            other.gameObject.SetActive(false);
            ToDoManager.instance.updateUI();
            endPanel.SetActive(true);
            uiToDisable1.SetActive(false);
            uiToDisable2.SetActive(false);
            ScoreManager.instance.countFinalScore();
            Timer.instance.stopTimer();
        }
    }
}
