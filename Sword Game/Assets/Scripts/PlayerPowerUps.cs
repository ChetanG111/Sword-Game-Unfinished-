using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPowerUps : MonoBehaviour
{
    public static PlayerPowerUps instance;

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
     
    }

 
    public void ApplyJumpBoost()
    {
        Debug.Log("Applying Effect Jump Boost to" + GameManager.instance.PlayerName);
        GetComponent<PlayerMove>().isDoubleJump = true;
    }

    public void ApplyInvisibility()
    {
        GetComponent<MeshRenderer>().enabled = false;
    }

    public void ApplyResistance()
    {
        GetComponent<PlayerHealth>().resistance += 20;
    }
}
