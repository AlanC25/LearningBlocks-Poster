using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


public class vb_anim : MonoBehaviour, IVirtualButtonEventHandler
{
    int sum, btn_1_num;
    public GameObject vbBtn1;
    public Animator cubeAni;
    // Start is called before the first frame update
    void Start()
    {
        btn_1_num = 1;
        vbBtn1 = GameObject.Find("btn_1");
        vbBtn1.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        cubeAni.GetComponent<Animator>();
        Debug.Log(sum);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        sum = numDisplay.sum;
        if (btn_1_num.Equals(sum))
        {
        cubeAni.Play("anim_cubeRotate");
        Debug.Log("Btn 1 Pressed");
        }
        else
        {
          cubeAni.Play("cube_animation");
        }

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        cubeAni.Play("none");
        Debug.Log("Btn 1 Released");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
