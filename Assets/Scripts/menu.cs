using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{    
    public void play()
    {
        SceneManager.LoadScene(1);
    }

    public void quit()
    {
        Application.Quit();
    }
}
