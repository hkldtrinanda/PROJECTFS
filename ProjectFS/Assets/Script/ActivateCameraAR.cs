using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateCameraAR : MonoBehaviour
{
   

    [SerializeField] public GameObject interactUI;

    [SerializeField] public GameObject CameraAr;



   


    public bool PlayerInRange;
    
    /*public GameManager2 gameManager;*/
    public void Start()
    {
        /*gameManager = FindObjectOfType<GameManager2>();*/
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && PlayerInRange)
        {
            if (CameraAr.activeInHierarchy)
            {
                
                CameraAr.SetActive(false);


                
            }
            else
            {

               
                CameraAr.SetActive(true);


                // dialogText.text = dialog;
                
            }
        }

       
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            interactUI.SetActive(true);
            PlayerInRange = true;
            /*gameManager.counter++;*/
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            interactUI.SetActive(false);
            PlayerInRange = false;
            

        }
    }
}