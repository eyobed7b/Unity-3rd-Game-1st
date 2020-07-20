using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompletLevel : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter(){
        gameManager.gameComplet();
    }
}
