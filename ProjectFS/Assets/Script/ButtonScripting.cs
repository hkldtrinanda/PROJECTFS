using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScripting : MonoBehaviour
{
    [Header("Panel Yang Diaktifkan Collidernya")]
    public GameObject PanelOn;
    public GameObject PanelOff;
    public AudioSource Springaudio;
    
    //Panel Canvas
    [Header("Panel Canvas")]
    public GameObject PanelCanvas;
    // Start is called before the first frame update
    public void PanelOns()
    {
        PanelOn.SetActive(true);
        PanelCanvas.SetActive(false);
        Springaudio.Play();
    }

    // Update is called once per frame
    public void PanelOffs()
    {
        PanelOff.SetActive(false);
        Springaudio.Play();
    }
}
