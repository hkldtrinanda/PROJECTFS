using System;
using System.Collections;
using TMPro;
using UnityEngine;

public class LeverScripting : MonoBehaviour
{

    public static LeverScripting instance;
    [Header("Menyalakan Mesin")] 
    public Animator animMesin;

    [Header("Spawner")] 
    public GameObject[] objectSpawn;
    public int jumlahApiPadam;
    public float timeBetweenSpawn = 5;
    public float emergencyWaitTime = 10f;

    [Header("Panel Lever")]
    public GameObject panelLever;
    
    [Header("Lampu Alarm")]
    public GameObject lampuAlarm;
    public GameObject lampuUtama;
    public GameObject SmokeScreen;
    public BoxCollider2D exitDoor;

    [Header("Audio Mesin")] 
    public AudioSource Enginestart;
    public GameObject Engineaudio;

    private void Awake()
    {
        instance = this;
    }

    public void Start()
    {
        animMesin.GetComponent<Animator>();
        
        objectSpawn[0].SetActive(false);
        
    }

    private void Update()
    {
        if (jumlahApiPadam != objectSpawn.Length)
            return;
        SmokeScreen.SetActive(true);
        exitDoor.isTrigger = true;

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
        Engineaudio.SetActive(true);
        
        //lampualarm
       
    }

    // Update is called once per frame
    public void PanelOffs()
    {
        animMesin.SetBool("MesinOn", false);
        /*Enginestart.Stop();*/
        
    }

    void SpawnObject()
    {
        StartCoroutine(WaitBeforeShow());
    }
    
    IEnumerator WaitBeforeShow()
    {
        yield return new WaitForSeconds(emergencyWaitTime);
        lampuAlarm.SetActive(true);
        lampuUtama.SetActive(false);
        for (int i = 0; i < objectSpawn.Length; i++)
        {
            Debug.Log("Spawning Object " + i);
            objectSpawn[i].SetActive(true);
            yield return new WaitForSeconds(timeBetweenSpawn);
            Debug.Log("Succesfuly Spawn Object " + i);

        }
    }
}
