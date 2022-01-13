using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class energyRegeneration : MonoBehaviour
{
    public float currentEnergy=100;
    [SerializeField] private AudioSource energySound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == ("Player") && currentEnergy < 100)
        {
            StartCoroutine("Regenerate");
            energySound.Play();

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == ("Player"))
        {
            StopCoroutine("Regenerate");
            energySound.Stop();

        }
    }
    public void removeEnergy(float boxEnergy)
    {
        currentEnergy -= boxEnergy;
        
    }

    IEnumerator Regenerate()
    {
        if(currentEnergy < 100)
        {
            for (float curEnergy = currentEnergy;currentEnergy<100;currentEnergy+=1)
            {
                yield return new WaitForSeconds(0.2f);
            }
        }
    }
}
