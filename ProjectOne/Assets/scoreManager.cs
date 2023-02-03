using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Using. TMPro;

public class scoreManager : MonoBehaviour
{
    //public TextMeshProUGUI scoreText;
    public Text scoreText;
    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + score.ToString(); 
    }

    // Update is called once per frame
    void Update()
    {
        score = ((int)Time.time);
        scoreText.text = "Score: " + ((int)score).ToString(); 
    }

}
