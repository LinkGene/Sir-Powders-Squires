using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayTheme : MonoBehaviour
{

    IEnumerator Start()
    {
        yield return new WaitForSeconds(1);
        FindObjectOfType<AudioManager>().Play("ThemeJuan");
    }

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        
    }
}
