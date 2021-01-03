using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vb9_anim : MonoBehaviour, IVirtualButtonEventHandler
{
    int sum, btn_9_num;
    public GameObject vbBtn9;
    public Animator cubeAni;
    // Start is called before the first frame update
    void Start()
    {
        btn_9_num = 9;
        vbBtn9 = GameObject.Find("btn_9");
        vbBtn9.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        cubeAni.GetComponent<Animator>();
        Debug.Log(sum);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        sum = numDisplay.sum;
        if (btn_9_num.Equals(sum)) {
        cubeAni.Play("anim_cubeRotate");
        Debug.Log("Btn 9 Pressed");
      }
      else
      {
        cubeAni.Play("cube_animation");
      }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        cubeAni.Play("none");
        Debug.Log("Btn 9 Released");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
