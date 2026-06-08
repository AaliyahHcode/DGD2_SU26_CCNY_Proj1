using TMPro;
using UnityEngine;

public class CheckItem : MonoBehaviour
{

    public bool isDying;
    public float value = 1f;
    private ItemsManager manager;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isDying = false;
        manager = FindAnyObjectByType<ItemsManager>();
    }

    private void Update()
    {
        if(isDying)
        {
            transform.localScale = transform.localScale * .99f;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("collided with: " + collision.gameObject);
        if (collision.gameObject.CompareTag("Basket"))
        {
            isDying = true;
            manager.score += value;
            manager.Score.text = "Score: " + manager.score.ToString();
            Destroy(gameObject, 0.15f);

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
 
        
        //previously had two OnTriggerEnter2D but Unity does not read two in the same, and it does not work physics wise
        if (collision.gameObject.CompareTag("Ground"))
        {
            isDying = true;
            Destroy(gameObject,.5f);
            
        }

    }




}
