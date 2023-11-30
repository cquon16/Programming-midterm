using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Vector3 Movement;
    private bool XORZ;

    Rigidbody ball;

    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.Find("Ball").GetComponent<Rigidbody>();
        XORZ = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (XORZ == true)
            {
                ball.velocity = Vector3.zero;
                XORZ = false;
                ball.AddForce(new Vector3(1,0,0) * 100f, ForceMode.Force);
            }

            else if (XORZ == false)
            {
                ball.velocity = Vector3.zero;
                XORZ = true;
                ball.AddForce(new Vector3(0,0,1) * 100f, ForceMode.Force);
            }
        }

    }

    void OnCollisionExit(Collision other)
    {
        ball.AddForce(new Vector3(0,-1,0) * 100f, ForceMode.Force);
    }

 
}
