using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    private float addend = 0.0f;
    public float rotationSpeed;
    public float up_multiplier = 1;
    public float down_multiplier = 1;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input

        // move the plane forward at an increasing speed
        transform.Translate(Vector3.forward * (speed + addend) * Time.deltaTime);
        // transform.position = new Vector3(transform.position.x, transform.position.y, newZPos);
        addend = addend + 0.005f;

        // tilt the plane up/down based on up/down arrow keys
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Rotate(Vector3.right, -up_multiplier * rotationSpeed * Time.deltaTime);
        }
        else
            transform.Rotate(Vector3.right, down_multiplier * rotationSpeed * Time.deltaTime);

    }
}
