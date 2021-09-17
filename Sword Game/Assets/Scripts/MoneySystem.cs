using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneySystem : MonoBehaviour
{
    public int numGold;
    public TextMeshProUGUI text;
    PowerupTracker powerup;

    public void Update()
    {
        text.text = numGold.ToString();
    }
    public void Buy(PowerUps power)
    {
        if (!powerup.unlocked[power.index].isUnlocked)
        {
            int i = numGold;
            i -= power.amount;
            if(i >= 0)
            {
                numGold -= power.amount;
                powerup.unlocked[power.index].isUnlocked = true;
            }
            else
            {
                Debug.Log("You Don't Have Enough Money");
            }
            
        }
    }
}
