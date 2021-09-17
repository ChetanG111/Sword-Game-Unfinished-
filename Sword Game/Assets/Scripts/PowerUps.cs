using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New PowerUp",menuName = "Powerups/Powerup")]
public class PowerUps : ScriptableObject
{
    public string powerName;
    public int amount;
    public int index;
    public enum PowerUpType {JumpBoost,Strength,Resistance,Invisibility};
    public PowerUpType powerupType;
    
    public virtual void Use()
    {
        Debug.Log("PlayerPicked " + powerName);
     if(this.powerupType == PowerUpType.JumpBoost)
        {
            PlayerPowerUps.instance.ApplyJumpBoost();
        }   
     else if(this.powerupType == PowerUpType.Invisibility)
     {
            PlayerPowerUps.instance.ApplyInvisibility();
     }
    }
}
