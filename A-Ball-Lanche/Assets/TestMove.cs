using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMove : MonoBehaviour
{
    private Rigidbody rb;
    private float lr;
    public float Left_Right_Speed = 10f;
    public float Starting_Speed = 5f;
    public float Ball_Speed_Increase = 0.0001f;
    public float Ball_Size_Increase = 0.0001f;
    public float JumpHeight = 7f;
    private float Jump;
    private Transform tf;
    private float newScale = 1f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        tf = GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        lr = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown("space"))
        {
            Jump = JumpHeight;
        }
        else
        {
            Jump = 0;
        }
        
        newScale += Ball_Size_Increase;

        this.transform.localScale = new Vector3(newScale, newScale, newScale); 

        Starting_Speed += Ball_Speed_Increase;

        rb.velocity = new Vector3(Starting_Speed * -1, rb.velocity.y + Jump, lr * Left_Right_Speed);
        //Debug.Log(rb.velocity);

        
        //rb.mass += MassUp;
    }
}
