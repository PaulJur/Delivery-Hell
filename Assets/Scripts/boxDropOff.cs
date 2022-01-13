using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class boxDropOff : MonoBehaviour
{
    public energyRegeneration energy;
    //If a box enters a pallet, it gets destroyed,gives score and removes energy.
    [SerializeField] private AudioSource deliverySound;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Box")
        {
            scoreScript.scoreValue += 50;
            Destroy(collision.gameObject);
            energy.removeEnergy(25f);
            deliverySound.Play();
           

        }
        if (energy.currentEnergy <= 0)
        {
            energy.currentEnergy = 0;
        }
    }





}
