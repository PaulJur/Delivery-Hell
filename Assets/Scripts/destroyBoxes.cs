using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyBoxes : MonoBehaviour
{

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "pickBoxConv")
        {
            Destroy(collision.gameObject);
        }
    }
}
