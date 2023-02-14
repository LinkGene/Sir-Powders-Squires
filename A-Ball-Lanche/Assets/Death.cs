using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public GameObject DeathPart;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void DestroyFromTree()
    {
        Debug.Log("He Died! you killed him!");
        Instantiate(DeathPart, transform.position, Quaternion.identity);
        Destroy(gameObject);
        
    }
}
