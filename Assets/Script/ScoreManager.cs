using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    int curentScore = 0;
    public Text scoreText;

    public static ScoreManager instance;
    // Start is called before the first frame update

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        scoreText.text = curentScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddScore()
    {
        curentScore += 10;
        scoreText.text = curentScore.ToString();

    }
}
