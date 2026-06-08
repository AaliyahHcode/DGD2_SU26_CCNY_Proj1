using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;


public class ItemsManager : MonoBehaviour
{
    public GameObject item;
    private bool RoundRun = true;
    public float speed = 3f;
    Rigidbody2D RB;
    public float score = 0f;
    public float value = 1f;

    public float RoundTimer = 30f;
    public float spawnTimer = 2f;
    float currentSpawnTimer;
    public TextMeshProUGUI Timer;
    public TextMeshProUGUI Score;
    // public TextMeshProUGUI Missed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentSpawnTimer = spawnTimer;
    }

    private void Update()
    {
        RoundTimer -= Time.deltaTime;
        Timer.text = "Timer: " + Mathf.Ceil(RoundTimer);
        if (RoundTimer <= 0f)
        {
            RoundTimer = 0f;
            RoundRun = false;
        }
        
        if(RoundRun == true)
        {
            currentSpawnTimer -= Time.deltaTime;
            
            if(currentSpawnTimer < 0f)
            {
                //spawns an item every 2 seconds (want to use Random.Range to do this in a certain space)
                Vector2 spawnPos = new Vector2(Random.Range(-8f, 8f), Random.Range(0.5f, 4f));
                
                GameObject spawnedItem = Instantiate(item, spawnPos, Quaternion.identity);
                spawnedItem.tag = "Item";
                currentSpawnTimer = spawnTimer;

            }

        }
    }
}



