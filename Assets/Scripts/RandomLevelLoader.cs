using UnityEngine;
using UnityEngine.SceneManagement;
public class RandomLevelLoader : MonoBehaviour
{
    public int levelGenerate;

    public void LevelLoading() 
    {
        levelGenerate = 2;
        SceneManager.LoadScene(levelGenerate);
    }
}
