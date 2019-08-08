using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btn_Animation : MonoBehaviour
{
    Animation animator;
    // Start is called before the first frame update
    void Start()
    {
        animator=GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("a"))
        animator.Play("btn1");
        
    }
}
