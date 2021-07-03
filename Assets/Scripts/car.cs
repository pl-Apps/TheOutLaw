using UnityEngine;

public class car : MonoBehaviour
{
    public GameObject usr;
    private GameObject latest_street_object;
    private Vector3 latest_street_object_vector;
    public GameObject usr_car;
    private Rigidbody usr_car_rb;
    private Camera usr_cam;
    private Camera usr_car_cam;
    private Vector3 usr_car_vector;
    private Vector3 rotationRight = new Vector3(0, 30, 0);
    private Vector3 rotationLeft = new Vector3(0, -30, 0);
    private bool usr_car_touching = false;
    private float base_usr_car_speed = 10f;
    private float usr_car_speed;
    private float acc = 0.1f;

    void Start()
    {
        usr_car_speed = base_usr_car_speed;
        usr_car_rb = usr_car.GetComponent<Rigidbody>();
        usr_cam = usr.GetComponent<Camera>();
        usr_car_cam = usr.GetComponent<Camera>();
        usr_car_vector = usr_car_rb.position;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            usr_car_speed += acc;
            usr_car_vector = usr_car.transform.forward * usr_car_speed * Time.deltaTime;
            usr_car_rb.MovePosition(usr_car.transform.position + usr_car_vector);
            usr_car_speed = base_usr_car_speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            usr_car_speed = base_usr_car_speed;
            usr_car_vector = usr_car.transform.forward * -usr_car_speed * Time.deltaTime;
            usr_car_rb.MovePosition(usr_car.transform.position + usr_car_vector);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Quaternion deltaRotationRight = Quaternion.Euler(rotationRight * Time.deltaTime);
            usr_car_rb.MoveRotation(usr_car_rb.rotation * deltaRotationRight);
        }

        if (Input.GetKey(KeyCode.A))
        {
            Quaternion deltaRotationLeft = Quaternion.Euler(rotationLeft * Time.deltaTime);
            usr_car_rb.MoveRotation(usr_car_rb.rotation * deltaRotationLeft);
        }
    }
}