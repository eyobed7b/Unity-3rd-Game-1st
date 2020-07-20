
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   bool isended = false;
   public float restartDelay = 1f;
   public GameObject completUi;
   public player playerMovemenrt;

public void gameComplet(){

 completUi.SetActive(true);


}

  public void endGame(){
    if(isended == false){
      isended= true;
   Debug.Log("Game over"); 
   Invoke("restart",restartDelay);
    }
      
  }
  void restart(){
   
     SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }
}
