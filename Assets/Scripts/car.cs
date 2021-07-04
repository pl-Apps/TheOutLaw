using UnityEngine;

public class car : MonoBehaviour
{
    private Rigidbody rb;
    public Transform target;
    private float speed;
    public static float base_speed = 10;
    public static float acceleration = 0.03f;


    Vector3 rotationRight = new Vector3(0, 30, 0);
    Vector3 rotationLeft = new Vector3(0, -30, 0);

    Vector3 forward = new Vector3(0, 0, 1);
    Vector3 backward = new Vector3(0, 0, -1);

    private void Start()
    {
        rb = target.GetComponent<Rigidbody>();
        speed = base_speed;
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(forward * speed * Time.deltaTime);
            speed += acceleration;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            speed = base_speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(backward * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Quaternion deltaRotationRight = Quaternion.Euler(rotationRight * Time.deltaTime);
            rb.MoveRotation(rb.rotation * deltaRotationRight);
        }

        if (Input.GetKey(KeyCode.A))
        {
            Quaternion deltaRotationLeft = Quaternion.Euler(rotationLeft * Time.deltaTime);
            rb.MoveRotation(rb.rotation * deltaRotationLeft);
        }

    }
}