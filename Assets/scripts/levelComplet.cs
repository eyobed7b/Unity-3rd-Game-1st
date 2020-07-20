
using UnityEngine;

using UnityEngine.SceneManagement;
public class levelComplet : MonoBehaviour
{
    public void LodNextLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
