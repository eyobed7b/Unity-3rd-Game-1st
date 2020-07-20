using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pleyer_col : MonoBehaviour
{
  

    public player playerMovemenrt;
    void OnCollisionEnter(Collision Collsioninfo){
        
        if( Collsioninfo.collider.tag == "obstacle"){
               playerMovemenrt.enabled = false;
               FindObjectOfType<GameManager>().endGame();
        }
    }
    


}
