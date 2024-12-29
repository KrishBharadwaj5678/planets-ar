using UnityEngine;
using UnityEngine.SceneManagement;  // Required for scene management

public class PlanetSceneLoader : MonoBehaviour
{
    // This method loads the scene based on the scene name provided
    public void LoadPlanetScene(string sceneName)
    {
        if (!string.IsNullOrEmpty(sceneName))
        {
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            Debug.LogError("Scene name is empty or null. Please provide a valid scene name.");
        }
    }
}
