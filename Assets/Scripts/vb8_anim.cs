using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vb8_anim : MonoBehaviour, IVirtualButtonEventHandler
{
    int sum, btn_8_num;
    public GameObject vbBtn8;
    public Animator cubeAni;
    // Start is called before the first frame update
    void Start()
    {
        btn_8_num = 8;
        vbBtn8 = GameObject.Find("btn_8");
        vbBtn8.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        cubeAni.GetComponent<Animator>();
        Debug.Log(sum);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        sum = numDisplay.sum;
        if (btn_8_num.Equals(sum)) {
        cubeAni.Play("anim_cubeRotate");
        Debug.Log("Btn 8 Pressed");
      }
      else
      {
        cubeAni.Play("cube_animation");
      }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        cubeAni.Play("none");
        Debug.Log("Btn 8 Released");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
