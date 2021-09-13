using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordSwitcher : MonoBehaviour
{
    public int selectedSword;
   [SerializeField] public static SwordSwitcher instance;
    void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        Switch();
    }

    // Update is called once per frame
    void Update()
    {
        
        int previousselected = selectedSword;

        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            if (selectedSword >= transform.childCount - 1)
                selectedSword = 0;
            else
                selectedSword++;

        }


        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            if (selectedSword <= 0)
                selectedSword = transform.childCount - 1;
            else
                selectedSword--;

        }

        if (previousselected != selectedSword)
            Switch();
    }

  public void Switch()
    {
        int i = 0;
        foreach (Transform sword in transform)
        {
            if (i == selectedSword && sword.GetComponent<Sword>().isEquipped)
                sword.gameObject.SetActive(true);
            else
                sword.gameObject.SetActive(false);
            i++;
        }
    }
}
