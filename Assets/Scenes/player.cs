using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
   public Rigidbody rb;
   public float forwardForce = 2000f;
   public float sidwayForce = 500f;
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,forwardForce * Time.deltaTime);
        if(Input.GetKey("d") ){
            rb.AddForce(sidwayForce * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }if(Input.GetKey("a") ){
            rb.AddForce(-sidwayForce * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if(rb.position.y < -1f){
            //  playerMovemenrt.enabled = false;
               FindObjectOfType<GameManager>().endGame();
        }
    }
}
