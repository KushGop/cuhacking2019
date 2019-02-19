using UnityEngine;

public class TankMove : MonoBehaviour
{

    
    public Rigidbody rb;
    public float move;
    public float speed;
    public float turnSpeed = 50f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.MovePosition(transform.position + transform.forward * speed * Time.deltaTime);

        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.MovePosition(transform.position - transform.forward * speed * Time.deltaTime);

        }

    }
}
