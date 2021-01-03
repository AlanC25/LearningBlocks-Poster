using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vb0_anim : MonoBehaviour, IVirtualButtonEventHandler
{
    int sum, btn_0_num;
    public GameObject vbBtn0;
    public Animator cubeAni;
    // Start is called before the first frame update
    void Start()
    {
        btn_0_num = 0;
        vbBtn0 = GameObject.Find("btn_0");
        vbBtn0.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        cubeAni.GetComponent<Animator>();
        Debug.Log(sum);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        sum = numDisplay.sum;
        if (btn_0_num.Equals(sum)) {
        cubeAni.Play("anim_cubeRotate");
        Debug.Log("Btn 0 Pressed");
      }
      else
      {
        cubeAni.Play("cube_animation");
      }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        cubeAni.Play("none");
        Debug.Log("Btn 0 Released");
    }

        // Update is called once per frame
        void Update()
    {

    }
}
