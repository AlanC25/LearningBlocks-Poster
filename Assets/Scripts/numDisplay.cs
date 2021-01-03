using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Vuforia;

public class numDisplay : MonoBehaviour, IVirtualButtonEventHandler
{
    int n1, n2;
    public static int sum;
    int x;
    public TextMeshPro n1Text, n2Text, sumText;
    public GameObject vbBtnReset;


    // Start is called before the first frame update
    void Start()
    {
        vbBtnReset = GameObject.Find("btn_reset");
        vbBtnReset.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        n1Text = n1Text.GetComponent<TextMeshPro>();
        n2Text = n2Text.GetComponent<TextMeshPro>();
        sumText = sumText.GetComponent<TextMeshPro>();
        ranNumGen();
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        ranNumGen();
        Debug.Log("Btn Reset Pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("btn Reset Released");
    }

    public void ranNumGen()
    {
        n1 = Random.Range(0, 10);
        n1Text.text = n1.ToString();

        n2 = Random.Range(0, 10);
        n2Text.text = n2.ToString();

        sumNums();
    }

    public void sumNums()
    {
        sum = n1 + n2;
        sumText.text = sum.ToString();// displays sum number, remove this and replace and display x.text and checkSum.
    }
    public void checkDigits()
    {
        if (sum >= 10)
        {
            ranNumGen();
        }
    }
    public void checkSum()
    {
        if(sum == x)
        {
            Debug.Log("Well done"); // Create UI overlay
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        checkDigits();
        checkSum();
    }


}
