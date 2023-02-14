using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScore : MonoBehaviour
{
    public GameObject ScoreManager;
    public int Score_Change = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter()
    {
        ScoreManager.GetComponent<ScoreManager>().AddScore(Score_Change);
        Debug.Log("They are Died! you killed them!");
        Destroy(gameObject);
    }
}
