
using UnityEngine;
using UnityEngine.SceneManagement;
public class startGamem : MonoBehaviour
{
   public void gamestart(){
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }
}
