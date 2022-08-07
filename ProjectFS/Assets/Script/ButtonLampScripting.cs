﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLampScripting : MonoBehaviour
{
    [Header("Panel Yang Diaktifkan Collidernya")]
    public GameObject PanelOn;
    public GameObject PanelOff;
    public GameObject LampOn;

    [Header("Acc Lampu")] public GameObject AccLampu;
    
    [Header("Animasi Mesin")]
    public Animator MesinAnim;
    
    //Panel Canvas
    [Header("Panel Canvas")]
    public GameObject PanelCanvas;
    // Start is called before the first frame update
    public void PanelOns()
    {
        PanelOn.SetActive(true);
        PanelCanvas.SetActive(false);
        LampOn.SetActive(true);
        AccLampu.SetActive(true);
    }

    // Update is called once per frame
    public void PanelOffs()
    {
        PanelOff.SetActive(false);
        LampOn.SetActive(false);
        AccLampu.SetActive(false);
        MesinAnim.SetBool("MesinOn", false);
    }

    private void Start()
    {
        LampOn.SetActive(false);
    }
}
