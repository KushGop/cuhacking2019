
using UnityEngine;

public class Turret : MonoBehaviour
{
    public float turnSpeed = 50f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("."))
        {
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(","))
        {
            transform.Rotate(Vector3.down, turnSpeed * Time.deltaTime);
        }
    }
}
