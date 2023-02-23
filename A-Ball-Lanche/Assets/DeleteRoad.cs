using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteRoad : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        Debug.Log("DeleteRoad Colision");
        GameObject other = collision.gameObject;

        other.GetComponent<Death>().DestroyThis();
    }

    
}
