using System;
using System.Collections;
using TMPro;
using UnityEngine;

public class LeverScripting : MonoBehaviour
{
    [Header("Menyalakan Mesin")] 
    public Animator animMesin;

    [Header("Spawner")] 
    public GameObject objectSpawn;
    
    [Header("Panel Lever")]
    public GameObject panelLever;
    
    [Header("Lampu Alarm")]
    public GameObject lampuAlarm;

    [Header("Audio Mesin")] 
    public AudioSource Enginestart;


    public void Start()
    {
        animMesin.GetComponent<Animator>();
        
        objectSpawn.SetActive(false);
        
        StartCoroutine(WaitBeforeShow());
    }

    // Start is called before the first frame update
    public void PanelOns()
    {
        animMesin.SetBool("MesinOn", true);
        
        //waitasecond
        
        objectSpawn.SetActive(true);
        
        //panel
        panelLever.SetActive(false);
        
        //audio
        Enginestart.Play();
        
        //lampualarm
        lampuAlarm.SetActive(true);
    }

    // Update is called once per frame
    public void PanelOffs()
    {
        animMesin.SetBool("MesinOn", false);
        Enginestart.Stop();
        
    }
    
    private IEnumerator WaitBeforeShow()
    {
        
        yield return new WaitForSeconds(10
        );
        objectSpawn.SetActive(true);
        lampuAlarm.SetActive(true);
        
    }
}
