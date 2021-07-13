using UnityEngine;
using UnityEngine.SceneManagement;

public class env : MonoBehaviour
{
    public GameObject player;
    public GameObject car;
    public Camera player_cam;
    public Camera car_cam;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            car.SetActive(!car.activeSelf);
            player.SetActive(!player.activeSelf);
            car_cam.enabled = !car_cam.enabled;
            player_cam.enabled = !player_cam.enabled;
        }
        if(Input.GetKeyDown(KeyCode.G))
        {
            Vector3 tmp;
            tmp.x = 0;
            tmp.y = 36;
            tmp.z = 56;
            player.GetComponent<Rigidbody>().MovePosition(tmp);
            car.GetComponent<Rigidbody>().MovePosition(tmp);
            Vector3 tmp3;
            tmp3.x = 0;
            tmp3.y = 1;
            tmp3.z = 0;
            Quaternion tmp1 = Quaternion.Euler(tmp3);
            player.GetComponent<Rigidbody>().MoveRotation(tmp1);
            car.GetComponent<Rigidbody>().MoveRotation(tmp1);
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }
}
