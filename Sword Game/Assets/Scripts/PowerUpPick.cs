using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpPick : MonoBehaviour
{
    public PowerUps power;
    public float speed;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            power.Use();
            Destroy(gameObject);
            
        }
    }
    private void Update()
    {
        transform.Rotate(0, speed, 0);
    }
}
