using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vb6_anim : MonoBehaviour, IVirtualButtonEventHandler
{
    int sum, btn_6_num;
    public GameObject vbBtn6;
    public Animator cubeAni;
    // Start is called before the first frame update
    void Start()
    {
        btn_6_num = 6;
        vbBtn6 = GameObject.Find("btn_6");
        vbBtn6.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        cubeAni.GetComponent<Animator>();
        Debug.Log(sum);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        sum = numDisplay.sum;
        if (btn_6_num.Equals(sum)) {
        cubeAni.Play("anim_cubeRotate");
        Debug.Log("Btn 6 Pressed");
      }
      else
      {
        cubeAni.Play("cube_animation");
      }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        cubeAni.Play("none");
        Debug.Log("Btn 6 Released");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
