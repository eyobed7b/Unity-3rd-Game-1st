
using UnityEngine;
using UnityEngine.SceneManagement;
public class startGame : MonoBehaviour
{
   public void startGameFun(){
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }
}
