using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MF_Level_Functions : MonoBehaviour
{
    //public GameObject MF;
    private GameObject NextPiece;
    private Transform SpawnPoint;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void Spawn_Next_MF()
    {

        if(NextPiece == null)
        {
            SpawnPoint = gameObject.transform.GetChild(5);
            NextPiece = Instantiate(gameObject, SpawnPoint.position, gameObject.transform.rotation);
        }
    }
}
