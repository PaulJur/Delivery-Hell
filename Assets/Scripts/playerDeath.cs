using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDeath : MonoBehaviour
{
 

    [SerializeField] private Transform Player;
    [SerializeField] private Transform respawnPoint;
    public AudioSource audioSource;

 

   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == ("Player"))
        {
            
            Player.transform.position = respawnPoint.transform.position;
            audioSource.Play();

        }


    }

    }
