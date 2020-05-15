using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryScript : MonoBehaviour
{
    public static string[] inventory = new string[4];
    public static int currentinvenindex = 0;
    public static bool GotPoker = false;
    public static bool GotSafe = false;
    public static bool GotGloves = false;
    public static bool GotGeode = false;

    public GameObject invenPoker;
    public GameObject invenSafe;
    public GameObject invenGloves;
    public GameObject invenGeode;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        checkInventory();
    }

    //adds inventory to an array. When the array is full I will eventually have it trigger dialogue.
    public void ClueClick(string clue)
    {
        inventory[currentinvenindex] = clue;

        if (currentinvenindex < 3)
        {
            currentinvenindex++;
        }
        else
        {
            Debug.Log("I'm done here.");
        }
    }

    //Sets item bools when objects are picked up
    public void PokerGet()
    {
        GotPoker = true;
    }

    public void SafeGet()
    {
        GotSafe = true;
    }

    public void GlovesGet()
    {
        GotGloves = true;
    }

    public void GeodeGet()
    {
        GotGeode = true;
    }


    //activates items in inventory
    void checkInventory()
    {
        if (GotPoker == true)
        {
            invenPoker.SetActive(true);
        }

        if (GotSafe == true)
        {
            invenSafe.SetActive(true);
        }

        if (GotGloves == true)
        {
            invenGloves.SetActive(true);
        }

        if (GotGeode == true)
        {
            invenGeode.SetActive(true);
        }
    }

}
