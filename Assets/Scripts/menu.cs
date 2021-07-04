using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public UnityEngine.UI.Text car_speed_value;

    private void Start()
    {
        UpdateSpeed();
    }

    void UpdateSpeed()
    {
        car_speed_value.text = car.base_speed.ToString();
    }
    public void plusSpeed()
    {
        Debug.Log("test");
        car.base_speed += 1;
        UpdateSpeed();
    }
    public void miniumSpeed()
    {
        car.base_speed -= 1;
        UpdateSpeed();
    }
    public void play()
    {
        SceneManager.LoadScene(1);
    }

    public void settings()
    {
        SceneManager.LoadScene(2);
    }

    public void quit()
    {
        Application.Quit();
    }
}
