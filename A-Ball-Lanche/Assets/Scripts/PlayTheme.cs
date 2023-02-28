using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayTheme : MonoBehaviour
{

    void Awake()
    {
        FindObjectOfType<AudioManager>().Play("ThemeJuan");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
