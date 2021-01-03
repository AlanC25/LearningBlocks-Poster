using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vb4_anim : MonoBehaviour, IVirtualButtonEventHandler
{
    int sum, btn_4_num;
    public GameObject vbBtn4;
    public Animator cubeAni;
    // Start is called before the first frame update
    void Start()
    {
        btn_4_num = 4;
        vbBtn4 = GameObject.Find("btn_4");
        vbBtn4.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        cubeAni.GetComponent<Animator>();
        Debug.Log(sum);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        sum = numDisplay.sum;
        if (btn_4_num.Equals(sum)) {
        cubeAni.Play("anim_cubeRotate");
        Debug.Log("Btn 4 Pressed");
      }
      else
      {
        cubeAni.Play("cube_animation");
      }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        cubeAni.Play("none");
        Debug.Log("Btn 4 Released");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
