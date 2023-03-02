using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMusic : MonoBehaviour
{
    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(1);
        FindObjectOfType<AudioManager>().Play("MenuTheme");
    }

    // Update is called once per frame
}
