using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabItem : MonoBehaviour
{

    GameObject holdedItem;
    Transform tempItemPosition;
    bool holdingItem;
    public Transform objectPosition;


    
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Grabable")
        {
            if (Input.GetButtonDown("Fire2"))
            {
                if (holdingItem)
                {
                    releaseItem();
                }
                holdingItem = true;
                holdedItem = other.gameObject;
                tempItemPosition = holdedItem.transform;
                grabItem();
            }
                
          
        }
    }

    void grabItem()
    {
        holdedItem.transform.position = objectPosition.position;
        holdedItem.transform.localScale = transform.localScale;
        holdedItem.transform.parent = transform;
        holdedItem.GetComponent<BoxCollider2D>().enabled = false;
    }

    void releaseItem()
    {
        holdedItem.GetComponent<BoxCollider2D>().enabled = true;
        holdedItem.transform.parent = null;
        holdedItem.transform.position = tempItemPosition.position;
        holdingItem = false;
     
    }
   
}
