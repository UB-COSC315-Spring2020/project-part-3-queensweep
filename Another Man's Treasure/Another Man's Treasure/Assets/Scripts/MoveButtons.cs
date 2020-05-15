using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveButtons : MonoBehaviour
{
    public void ToFoyer()
    {
        SceneManager.LoadScene("Foyer");
    }

    public void ToDiningRoom()
    {
        SceneManager.LoadScene("Dining Room");
    }

    public void ToOffice()
    {
        SceneManager.LoadScene("Office");
    }

    public void ToLibrary()
    {
        SceneManager.LoadScene("Library");
    }

    public void ToBedroom()
    {
        SceneManager.LoadScene("Bedroom");
    }

    public void ToGarden()
    {
        SceneManager.LoadScene("Garden");
    }
}
