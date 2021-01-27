using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class makeamanmove : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 5f;

    private Rigidbody rb;

    private void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float xDir = Input.GetAxis("Horizontal");
        float zDir = Input.GetAxis("Vertical");
        Vector3 targetVelocity = new Vector3(xDir, 0, zDir);

        rb.velocity = targetVelocity * moveSpeed;
    }
}


