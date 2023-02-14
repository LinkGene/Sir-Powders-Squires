using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GetScore : MonoBehaviour
{
    public GameObject ScoreManager;
    private TextMeshProUGUI Text; 
    // Start is called before the first frame update
    void Start()
    {
        Text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        Text = gameObject.GetComponent<TextMeshProUGUI>();


        Text.text = "Score: " + ScoreManager.GetComponent<ScoreManager>().CurrentScore;
    }
}
