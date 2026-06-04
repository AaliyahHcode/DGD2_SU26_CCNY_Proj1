using UnityEngine;
using TMPro;
using UnityEditor.Build;
using NUnit.Framework;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{

    public static GameManager _instance;
    public float timer = 3f;
    public float gameTimer = 60f;
    public TextMeshProUGUI gameTimeText;
    public TextMeshProUGUI scoreText;

    public GameObject myObject;
    public GameObject myPlayer;
    public PlayerWASD myWASD;
    public PlayerWASD playerScript;
    Rigidbody2D playerRB;
    public bool gameOn;

    public List<Coin> allCoins;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        _instance = this;
    }

    void Start()
    {
        gameOn = true;
        // myPlayer = GameObject.Find("Player");
        myPlayer = PlayerWASD.THEplayer.gameObject;
        //myWASD = myPlayer.GetComponent<PlayerWASD>();
        
        playerScript = PlayerWASD.THEplayer;
        playerRB = myPlayer.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       
        if(gameTimer > 0)
        {
            gameTimer -= Time.deltaTime;    
            if(gameTimer <= 0) 
            {
                playerRB.freezeRotation = false;
                playerScript.enabled = false;
                playerRB.AddForce(Vector3.up * 100f);
                playerRB.AddTorque(5f);
                foreach (Coin c in allCoins)
                {
                    Destroy(c.gameObject);
                }
                Debug.Log("GAME OVER");
                gameOn = false;
            }
        }
        gameTimeText.text = gameTimer.ToString("F1"); 
        scoreText.text = playerScript.score.ToString();
    }
}
