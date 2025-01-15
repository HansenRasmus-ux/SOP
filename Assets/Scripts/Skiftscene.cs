
using UnityEngine;
using UnityEngine.SceneManagement;

public class Startknap : MonoBehaviour
{
   public void startgame(string sceneName) 
   {
      SceneManager.LoadScene(sceneName);
   }
}
