
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance {get; private set;}

    private int score;
    private int gameTime;

    public TextMeshProUGUI scoreText;
    public GameObject banner;
    public GameObject button;

    // public GameObject building;

    void Awake() {
        if (Instance == null) {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }

    }

    public void StartGame() {
        score = 0;
        scoreText.text = "Score : " + score;

        // building.GetComponent<Building>().DropPianos();
        banner.SetActive(false);
        button.SetActive(false);
    }

    public void StopGame() {
        // building.GetComponent<Building>().StopDropping();
        banner.SetActive(true);
        button.SetActive(true);
    }

    public void resetScore(){
        int temp = 0;
        temp = (int)Time.time;
        gameTime=temp;
        score = (int)Time.time - gameTime;;
        scoreText.text = "Score: " + ((int)score).ToString(); 
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score = (int)Time.time - gameTime;
        //score = ((int)Time.time);
        scoreText.text = "Score: " + ((int)score).ToString(); 
    }
}