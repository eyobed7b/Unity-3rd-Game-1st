
using UnityEngine;

public class player_collison : MonoBehaviour
{
    public player playerMovemenrt;
    void OnCollisionEnter(Collision Collsioninfo){
        
        if( Collsioninfo.collider.tag == "obstacle"){
               playerMovemenrt.enabled = false;
              
        }
    }
    
}
