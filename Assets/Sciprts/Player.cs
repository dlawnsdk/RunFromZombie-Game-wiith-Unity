using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody characterRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        characterRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x     = Input.GetAxis("Horizontal");
        float y     = Input.GetAxis("Vertical");
        float jump  = Input.GetAxis("Jump");

        Vector3 velocity = new Vector3(x, jump, y);
        velocity *= speed;

        characterRigidbody.velocity = velocity;

    }
}
