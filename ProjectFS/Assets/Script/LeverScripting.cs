using System;
using System.Collections;
using TMPro;
using UnityEngine;

public class LeverScripting : MonoBehaviour
{
    [Header("Menyalakan Mesin")] 
    public Animator animMesin;

    [Header("Spawner")] 
    public GameObject[] objectSpawn;
    public float timeBetweenSpawn = 5;
    
    [Header("Panel Lever")]
    public GameObject panelLever;
    
    [Header("Lampu Alarm")]
    public GameObject lampuAlarm;

    [Header("Audio Mesin")] 
    public AudioSource Enginestart;


    public void Start()
    {
        animMesin.GetComponent<Animator>();
        
        objectSpawn[0].SetActive(false);
        
    }

    // Start is called before the first frame update
    public void PanelOns()
    {
        animMesin.SetBool("MesinOn", true);

        //waitasecond

        SpawnObject();
        
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

    void SpawnObject()
    {
        StartCoroutine(WaitBeforeShow());
    }
    
    IEnumerator WaitBeforeShow()
    {
        while (true)
        {
            for (int i = 0; i < objectSpawn.Length; i++)
            {
                Debug.Log("Spawning Object " + i);
                yield return new WaitForSeconds(timeBetweenSpawn);
                objectSpawn[i].SetActive(true);
                Debug.Log("Succesfuly Spawn Object " + i);

            }
        }
       
        
      
       
    }
}
