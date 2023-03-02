using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    public GameObject GameOver;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        GameObject other = collision.gameObject;
        
        other.GetComponent<Death>().DestroyFromTree();
        if (gameObject.tag == "Finish")
        {
            Debug.Log("it Crashed into the Cabin");
            GameOver.SetActive(true);
        }
    }
}
