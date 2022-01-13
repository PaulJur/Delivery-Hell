using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class grabController : MonoBehaviour
{
    //boxHolder is the gammeobject position where the player holds the box.
    public Transform boxHolder;
    public energyRegeneration energy;

    public playerDeath death;

    public Vector3 Direction {get;set;}//gets the direction where the player is looking.
    public LayerMask pickUp; //Sets which layer is grabbable by the player.

    private GameObject itemHolding;
    Collider2D pickUpItem;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        { //if the player is holding and item/object and presses E the object becomes simulated again and drops on the direction of where the player is looking.
            if (itemHolding)
            {
                itemHolding.transform.position = transform.position + Direction;
                itemHolding.transform.parent = null;
                if (itemHolding.GetComponent<Rigidbody2D>())
                    itemHolding.GetComponent<Rigidbody2D>().simulated = true;
                itemHolding = null;
            }
            else {
               
                if (energy.currentEnergy < 25)
                    {
                        pickUpItem = Physics2D.OverlapCircle(transform.position + Direction, 0f);
                    }
                    else
                    {
                        pickUpItem = Physics2D.OverlapCircle(transform.position + Direction, 0.1f, pickUp);
                    if (pickUpItem)
                    {
                        itemHolding = pickUpItem.gameObject;
                        itemHolding.transform.position = boxHolder.position;
                        itemHolding.transform.parent = transform;
                        itemHolding.GetComponent<Rigidbody2D>().simulated = false;
                        
                    }
                  }       
                
                //Sets the picked up objects simulation to false, and makes it's position the same as the boxholder variable.

            }
        }
             
        
    }



}
