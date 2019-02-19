
using UnityEngine;

public class Turret2 : MonoBehaviour
{
    public float turnSpeed = 50f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("e"))
        {
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        }
        else if (Input.GetKey("q"))
        {
            transform.Rotate(Vector3.down, turnSpeed * Time.deltaTime);
        }
    }
}
