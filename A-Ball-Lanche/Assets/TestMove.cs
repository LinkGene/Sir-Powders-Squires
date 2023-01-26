using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMove : MonoBehaviour
{
    private Rigidbody rb;
    private float lr;
    public float Speed = 5f;
    public float SlopeSpeedStart = 5f;
    public float SlopeSpeedUp = 0.0001f;
    public float ScaleUp = 0.0001f;
    public float JumpSpeed = 7f;
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
            Jump = JumpSpeed;
        }
        else
        {
            Jump = 0;
        }
        
        newScale += ScaleUp;

        this.transform.localScale = new Vector3(newScale, newScale, newScale); 

        SlopeSpeedStart += SlopeSpeedUp;

        rb.velocity = new Vector3(SlopeSpeedStart * -1, rb.velocity.y + Jump, lr * Speed);
        //Debug.Log(rb.velocity);

        
        //rb.mass += MassUp;
    }
}
