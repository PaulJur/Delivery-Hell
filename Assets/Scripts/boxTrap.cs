using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxTrap : MonoBehaviour
{
    public GameObject trap;
    void Start()
    {
        trap.SetActive(false);
    }


    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == ("Player"))
        {
            trap.SetActive(true);
            
        }
    }
}
