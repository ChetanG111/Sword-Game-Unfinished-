using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupTracker : MonoBehaviour
{
    
    public GameObject[] gameObjects;
    public unlocked[] unlocked;

    private void Update()
    {
        for (int i = 0; i < unlocked.Length; i++)
        {
            if ( unlocked[i].isUnlocked)
            {
                gameObjects[i].SetActive(true);
            }

            else
            {
                gameObjects[i].SetActive(false);
            }
        }
    }
}
[SerializeField]
public class unlocked
{
    public bool isUnlocked;
    public PowerUps power;
}
