using UnityEngine;

public class TankMove2 : MonoBehaviour
{


    public Rigidbody rb;
    public float move;
    public float speed;
    public float turnSpeed = 50f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("s"))
        {
            rb.MovePosition(transform.position + transform.forward * speed * Time.deltaTime);

        }
        else if (Input.GetKey("d"))
        {
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        }
        else if (Input.GetKey("a"))
        {
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
        }
        else if (Input.GetKey("w"))
        {
            rb.MovePosition(transform.position - transform.forward * speed * Time.deltaTime);

        }

    }
}
