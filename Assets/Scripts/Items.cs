using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEditor.Progress;

public class Items : MonoBehaviour
{
    private bool RoundRun = true;
    public float speed = 3f;
    Rigidbody2D RB;
    public float score = 0f;
    public float value = 1f;
    public Rigidbody2D item;

    public float RoundTimer = 30f;
    public TextMeshPro Timer;
    public TextMeshPro Score;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.CompareTag("Ground"))
        {
           Destroy(this.gameObject);
        }
    }


    // spawn items here void Update()
    void Update()
    {
        if (RoundTimer > 0)
        {
                if (RoundRun == true)
                {
                    // Instantiate copies 10 of the items 5 units from each other 
                    //from unity Documentation
                    // https://docs.unity3d.com/ScriptReference/Object.Instantiate.html?ampDeviceId=8a95f3b6-43f7-4cf2-93df-cf779b1e910d&ampSessionId=1780589843116&ampTimestamp=1780678039022

                    for (int i = 0; i < 2; i++)
                    {
                        Instantiate(gameObject, new Vector3(i * 5.0f, 0, 0), Quaternion.identity);
                    }

                }
            }
        }
    }



