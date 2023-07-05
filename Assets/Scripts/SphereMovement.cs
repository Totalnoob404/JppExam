using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : PlayerMovement
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    protected override void Movement()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * verticalInput * Time.deltaTime * speed);
    }
    
}
