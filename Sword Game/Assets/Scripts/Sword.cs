using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Sword : MonoBehaviour
{
    public bool isEquipped;
    void Update()
    {
        if (isEquipped)
        {
            SwordSwitcher.instance.Switch();
        }
    }
}
