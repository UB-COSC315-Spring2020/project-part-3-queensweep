using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClueScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        checkGot();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Checks inventory script to see if an item has been collected and keeps the item from activating again
    void checkGot()
    {
        if (this.CompareTag("poker") && InventoryScript.GotPoker == true)
        {
            this.gameObject.SetActive(false);
        }

        if (this.CompareTag("safe") && InventoryScript.GotSafe == true)
        {
            this.gameObject.SetActive(false);
        }

        if (this.CompareTag("geode") && InventoryScript.GotGeode == true)
        {
            this.gameObject.SetActive(false);
        }

        if (this.CompareTag("gloves") && InventoryScript.GotGloves == true)
        {
            this.gameObject.SetActive(false);
        }

    }

}
