﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vb3_anim : MonoBehaviour, IVirtualButtonEventHandler
{
    int sum, btn_3_num;
    public GameObject vbBtn3;
    public Animator cubeAni;
    // Start is called before the first frame update
    void Start()
    {
        btn_3_num = 3;
        vbBtn3 = GameObject.Find("btn_3");
        vbBtn3.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        cubeAni.GetComponent<Animator>();
        Debug.Log(sum);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        sum = numDisplay.sum;
        if (btn_3_num.Equals(sum)) {
        cubeAni.Play("anim_cubeRotate");
        Debug.Log("Btn 3 Pressed");
      }
      else
      {
        cubeAni.Play("cube_animation");
      }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        cubeAni.Play("none");
        Debug.Log("Btn 3 Released");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
