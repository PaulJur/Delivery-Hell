using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class energyAmount : MonoBehaviour
{
    public energyRegeneration energy;
    Text amountEnergy;

    void Start()
    {
        amountEnergy = GetComponent<Text>();
    }

    
    void Update()
    {
        amountEnergy.text = "Energy: " + energy.currentEnergy;
    }
}
