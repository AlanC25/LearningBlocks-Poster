using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vb7_anim : MonoBehaviour, IVirtualButtonEventHandler
{
    int sum, btn_7_num;
    public GameObject vbBtn7;
    public Animator cubeAni;
    // Start is called before the first frame update
    void Start()
    {
        btn_7_num = 7;
        vbBtn7 = GameObject.Find("btn_7");
        vbBtn7.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        cubeAni.GetComponent<Animator>();
        Debug.Log(sum);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        sum = numDisplay.sum;
        if (btn_7_num.Equals(sum)) {
        cubeAni.Play("anim_cubeRotate");
        Debug.Log("Btn 7 Pressed");
      }
      else
      {
        cubeAni.Play("cube_animation");
      }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        cubeAni.Play("none");
        Debug.Log("Btn 7 Released");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
