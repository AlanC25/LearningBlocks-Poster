using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vb5_anim : MonoBehaviour, IVirtualButtonEventHandler
{
    int sum, btn_5_num;
    public GameObject vbBtn5;
    public Animator cubeAni;
    // Start is called before the first frame update
    void Start()
    {
        btn_5_num = 5;
        vbBtn5 = GameObject.Find("btn_5");
        vbBtn5.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        cubeAni.GetComponent<Animator>();
        Debug.Log(sum);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        sum = numDisplay.sum;
        if (btn_5_num.Equals(sum)) {
        cubeAni.Play("anim_cubeRotate");
        Debug.Log("Btn 5 Pressed");
      }
      else
      {
        cubeAni.Play("cube_animation");
      }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        cubeAni.Play("none");
        Debug.Log("Btn 5 Released");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
