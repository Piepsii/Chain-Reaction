using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float force = 1f;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb  = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0f, 0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, force, ForceMode.Impulse);
    }
}
