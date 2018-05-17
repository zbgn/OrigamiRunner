using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameController : MonoBehaviour {

	public static GameController instance;       
    public Text scoreText;                     
    public GameObject gameOvertext;           

    private int score = 0;                     
    public bool gameOver = false;             
    public float scrollSpeed = 8f;  

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if(instance != this)
            Destroy (gameObject);
    }

    void Update()
    {
        //If the game is over and the player has pressed some input...
        if (gameOver && Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
         if (Input.GetKey("escape"))
            Application.Quit();
    }

    public void RunnerScored(int i = 1)
    {
        if (gameOver)   
            return; 
        score = score + i;
        scoreText.text = "Score: " + score.ToString();
    }

    public void RunnerDied()
    {
        gameOvertext.SetActive (true);
        gameOver = true;
    }
}