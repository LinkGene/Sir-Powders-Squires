using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Lev1_Byron()
    {
        SceneManager.LoadScene("Level 1 Mountain", LoadSceneMode.Single);   
    }
    
    public void Lev1_Juan()
    {
        SceneManager.LoadScene("Juan Level Test", LoadSceneMode.Single); 
    }
    
    public void Lev_Hub()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
}


