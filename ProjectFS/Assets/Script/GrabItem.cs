using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabItem : MonoBehaviour
{

    GameObject holdedItem;
    Transform tempItemPosition;
    bool holdingItem;
    public Transform objectPosition;
    public AnimatorOverrideController animAPAR;
    public RuntimeAnimatorController defaultAnim;
    public Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Grabable")
        {
            if (Input.GetKeyDown(KeyCode.E))
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
        anim.runtimeAnimatorController = animAPAR as RuntimeAnimatorController;
        holdedItem.transform.position = objectPosition.position;
        holdedItem.transform.localScale = transform.localScale;
        holdedItem.SetActive(false);
        holdedItem.transform.parent = transform;
        holdedItem.GetComponent<BoxCollider2D>().enabled = false;
  
        Player_Attack.instance.canShoot = true;
    }

    void releaseItem()
    {
        holdedItem.SetActive(true);
        anim.runtimeAnimatorController = defaultAnim as RuntimeAnimatorController;
        holdedItem.GetComponent<BoxCollider2D>().enabled = true;
        holdedItem.transform.parent = null;
        holdedItem.transform.position = tempItemPosition.position;
        holdingItem = false;
        Player_Attack.instance.canShoot = false;

    }
   
}
