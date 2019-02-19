using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    GameObject prefab;
    public Transform tankHead;
    // Start is called before the first frame update
    void Start()
    {
        prefab = Resources.Load("Sphere") as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Slash))
        {
            GameObject sphere = Instantiate(prefab) as GameObject;
            sphere.transform.position = tankHead.position - tankHead.transform.forward * 2;
            Rigidbody rb = sphere.GetComponent<Rigidbody>();
            rb.velocity = -tankHead.transform.forward * 40;
        }
    }
}