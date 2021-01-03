using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


public class vb2_anim : MonoBehaviour, IVirtualButtonEventHandler
{
    int sum, btn_2_num;
    public GameObject vbBtn2;
    public Animator cubeAni;
    // Start is called before the first frame update
    void Start()
    {
        btn_2_num = 2;
        vbBtn2 = GameObject.Find("btn_2");
        vbBtn2.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        cubeAni.GetComponent<Animator>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        sum = numDisplay.sum;
        if (btn_2_num.Equals(sum)) {
        cubeAni.Play("anim_cubeRotate");
        Debug.Log("Btn 2 Pressed");
      }
      else
      {
        cubeAni.Play("cube_animation");
      }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        cubeAni.Play("none");
        Debug.Log("Btn 2 Released");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
