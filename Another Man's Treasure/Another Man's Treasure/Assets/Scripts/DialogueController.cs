using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueController : MonoBehaviour
{
    public float textspeed = 0.1f;
    public string fulltext;
    string currentText = "";
    public Text dialogue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnEnable()
    {
        StartCoroutine(ShowText());
    }

    //Gives text a typing effect
    IEnumerator ShowText()
    {
        for (int i = 0; i < fulltext.Length; i++)
        {
            currentText = fulltext.Substring(0, i);
            dialogue.text = currentText;
            yield return new WaitForSeconds(textspeed);
        }
    }
}
