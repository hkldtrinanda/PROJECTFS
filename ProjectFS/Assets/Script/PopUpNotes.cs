using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpNotes : MonoBehaviour
{
    [Header("Panel Open/Close")]
    [SerializeField] public GameObject imageNote;
    
    [Header("Interaksi Button")]
    [SerializeField] public GameObject interactUI;
    
    




    public bool PlayerInRange;
    
    /*public GameManager2 gameManager;*/
    public void Start()
    {
        /*gameManager = FindObjectOfType<GameManager2>();*/
    }

    public void CloseNote()
    {
        imageNote.SetActive(false);
        interactUI.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && PlayerInRange)
        {
            if (imageNote.activeInHierarchy)
            {
                imageNote.SetActive(false);

                
            }
            else
            {

                imageNote.SetActive(true);

                // dialogText.text = dialog;
                
            }
        }

        /*if (Input.GetKeyDown(KeyCode.E) && PlayerInRange)
        {
            anim.SetBool("IsOpen", true);
        }
        else
         {
            anim.SetBool("IsOpen", false);
         }*/
        
        
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
            imageNote.SetActive(false);

        }
    }
}