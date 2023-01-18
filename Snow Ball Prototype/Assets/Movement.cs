using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    private Rigidbody rb;
    private Vector3 Move;
    public bool isGravity;
    private bool isLeftPressedDown;
    private bool isRightPressedDown;
    private bool isRightUp;
    private bool isLeftUp;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        gameObject.GetComponent<Rigidbody> ().useGravity = isGravity;
    }

    // Update is called once per frame
    void Update()
    {
        isLeftPressedDown = Input.GetKeyDown("a");
        isRightPressedDown = Input.GetKeyDown("d");
        isLeftUp = Input.GetKeyUp("a");
        isRightUp = Input.GetKeyUp("d");
    }

    void FixedUpdate()
    {
        if (isLeftPressedDown)
        {
            // the cube is going to move upwards in 10 units per second
            Move = rb.velocity;
            Move.z = -5;
            rb.velocity = Move;
            // rb.velocity = new Vector3(0, 0, -5);
            Debug.Log("Left");
        }
        if (isRightPressedDown)
        {
            // the cube is going to move upwards in 10 units per second
            Move = rb.velocity;
            Move.z = 5;
            rb.velocity = Move;
            //rb.velocity = new Vector3(0, 0, 5);
            Debug.Log("Right");
        }
        
        if (isLeftUp | isRightUp)
        {
            //rb.velocity = new Vector3(0, 0, 0);
            //Move = rb.velocity;
            //Move.z = 0;
            //rb.velocity = Move;
        }
    }


}
