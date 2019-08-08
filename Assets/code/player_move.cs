using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class player_move : MonoBehaviour
{
    Rigidbody rigidbody;

    public int speed;

    public int speed_Slide;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody=GetComponent<Rigidbody>();
    }

    private void FixedUpdate() 
    {
        rigidbody.AddForce(0,0,speed*Time.deltaTime);

         if(Input.GetKey("a" ))
         {
            rigidbody.AddForce(-speed_Slide*Time.deltaTime,0,0,ForceMode.VelocityChange);
         }
         else if(Input.GetKey("d"))
          {
         rigidbody.AddForce(speed_Slide*Time.deltaTime,0,0,ForceMode.VelocityChange);
          }

          if(transform.position.y <=0)
          {
              SceneManager.LoadScene(0);
          }
        
    }


    public void Move_Rigth()
    {
        rigidbody.AddForce(speed_Slide*Time.deltaTime,0,0,ForceMode.VelocityChange);

    }

    public void Move_left()
    {
        rigidbody.AddForce(-speed_Slide*Time.deltaTime,0,0,ForceMode.VelocityChange);

    }

    private void OnTriggerEnter(Collider other)
     {
        if(other.tag=="C")
        {
            SceneManager.LoadScene(0);
        }
        else if(other.tag=="end")
        {
              SceneManager.LoadScene(1);
        }
    }
       
}
