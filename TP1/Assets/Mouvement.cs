using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouvement : MonoBehaviour
{
    public float speed = 0.01f;
    public float sprint = 0.05f;
    public Vector3 jump;
    public float jumpForce = 2.0f;
    public bool isGrounded;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
    	rb = GetComponent<Rigidbody>();
    	jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    void OnCollisionStay()
    {
    	isGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
        transform.Translate(Vector3.forward * speed);
        }
        if (Input.GetKey(KeyCode.Z))
        {
        transform.Translate(Vector3.back * speed);
        }
        if (Input.GetKey(KeyCode.Q))
        {
        transform.Rotate(Vector3.up, -2);
        }
        if (Input.GetKey(KeyCode.D))
        {
        transform.Rotate(Vector3.up, 2);
        }
    	if(Input.GetKeyDown("space") && isGrounded){
    		rb.AddForce(jump * jumpForce, ForceMode.Impulse);
    		isGrounded = false;
    	}
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = sprint;
        }
        else
        {
            speed = speed;
        }
    }
}
