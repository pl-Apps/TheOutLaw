using UnityEngine;

public class car : MonoBehaviour
{
    private Rigidbody rb;
    public Transform target;
    private float speed;
    public static float base_speed = 15f;
    public static float acceleration = 0.5f;
    public UnityEngine.UI.Text KMHLogger;

    Vector3 rotationRight = new Vector3(0, 30, 0);
    Vector3 rotationLeft = new Vector3(0, -30, 0);

    Vector3 forward = new Vector3(0, 0, 1);
    Vector3 backward = new Vector3(0, 0, -1);

    private void Start()
    {
        rb = target.GetComponent<Rigidbody>();
        speed = base_speed;
            Vector3 tmp;
            tmp.x = 0;
            tmp.y = 36;
            tmp.z = 56;
            target.GetComponent<Rigidbody>().MovePosition(tmp);
            Vector3 tmp3;
            tmp3.x = 0;
            tmp3.y = 0;
            tmp3.z = 0;
            Quaternion tmp1 = Quaternion.Euler(tmp3);
            target.GetComponent<Rigidbody>().MoveRotation(tmp1);
    }

    void FixedUpdate()
    {
        KMHLogger.text = "KM/H: " + (rb.velocity.magnitude * 3.6f).ToString().Split(',')[0];
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