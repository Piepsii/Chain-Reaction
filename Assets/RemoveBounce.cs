using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveBounce : MonoBehaviour
{
    public SphereCollider sphere;
    private BoxCollider col;

    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<BoxCollider>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider == sphere)
        {
            sphere.material.bounciness = 0;
        }
    }
}
