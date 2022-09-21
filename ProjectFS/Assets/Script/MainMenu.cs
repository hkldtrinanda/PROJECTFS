using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
  public string scene;
  public GameObject Creditpanel;
  public GameObject PausePanel;


    
  public void playGame ()
    {
        
        SceneManager.LoadScene(scene);
      
    }
  

  public void QuitGame()
      {
          Application.Quit();
      }

  public void creditScene()
  {
      PausePanel.SetActive(true);
      Creditpanel.SetActive(false);
  }
  
  public void PauseScene()
  {
      PausePanel.SetActive(false);
      Creditpanel.SetActive(true);
  }

  public void Update()
  {
      if(Input.GetKeyDown(KeyCode.Escape))
      {
         PausePanel.SetActive(false);
      }
  }
}
