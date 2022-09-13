using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLampScripting : MonoBehaviour
{
    [Header("Panel Yang Diaktifkan Collidernya")]
    public GameObject PanelOn;
    public GameObject PanelOff;
    public GameObject LampOn;
    public AudioSource SpringSound;

    [Header("Acc Lampu")] public GameObject AccLampu;
    
    [Header("Animasi Mesin")]
    public Animator MesinAnim;
    
    //Panel Canvas
    [Header("Panel Canvas")]
    public GameObject PanelCanvas;
    // Start is called before the first frame update
    public void PanelOns()
    {
        ToDoManager.instance.updateUI();
        PanelOn.SetActive(true);
        PanelCanvas.SetActive(false);
        LampOn.SetActive(true);
        AccLampu.SetActive(true);
        SpringSound.Play();
    }

    // Update is called once per frame
    public void PanelOffs()
    {
        PanelOff.SetActive(false);
        LampOn.SetActive(false);
        AccLampu.SetActive(false);
        MesinAnim.SetBool("MesinOn", false);
        SpringSound.Play();
    }

    private void Start()
    {
        LampOn.SetActive(false);
    }
}
