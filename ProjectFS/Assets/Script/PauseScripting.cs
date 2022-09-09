using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScripting : MonoBehaviour
{
    [Header("On/Off")] 
    public GameObject PauseON;
    public AudioSource PauseSoundOn;
    public GameObject PauseOFF;

    
    [Header("PanelOpsi")]
    public GameObject PanelOpsii;
    
    
    [Header("AnimasiSlider")]
    public Animator SliderAnim;
    // Start is called before the first frame update
    public void PanelOns()
    {
        SliderAnim.SetBool("Slider", true);
        
        PauseON.SetActive(true);
        
        PauseOFF.SetActive(false);
        PauseSoundOn.Play();

        
    }

    // Update is called once per frame
    public void PanelOffs()
    {
        SliderAnim.SetBool("SliderDown", true);
        PauseOFF.SetActive(true);
        PauseON.SetActive(false);
        PauseSoundOn.Play();
  
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (PauseON.activeSelf)
            {
                Time.timeScale = 1f;
                PanelOffs();
                
            }
            else
            {
                Time.timeScale = 1f;
                PanelOns();
                
            }
        }

    }
    
    public void PanelOpsi()
    {
        PanelOpsii.SetActive(true);
        PauseON.SetActive(false);
    }
    public void PanelOpsiOff()
    {
        PanelOpsii.SetActive(false);
        PauseON.SetActive(true);
    }
}
