using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartupMachineWithAnim : MonoBehaviour
{
    public GameObject PanelOn;
    public GameObject PanelOff;
    public Animator gambarGerak;
    
    //Panel Canvas
    public GameObject PanelCanvas;
    // Start is called before the first frame update
    public void PanelOns()
    {
        PanelOn.SetActive(true);
        PanelCanvas.SetActive(false);
        gambarGerak.SetBool("On", true);
    }

    // Update is called once per frame
    public void PanelOffs()
    {
        PanelOff.SetActive(false);
        PanelCanvas.SetActive(false);
        gambarGerak.SetBool("On", false);
    }
}