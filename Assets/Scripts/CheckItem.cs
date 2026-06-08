using TMPro;
using UnityEngine;

public class CheckItem : MonoBehaviour
{

    public float value = 1f;
    private ItemsManager manager;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        manager = FindAnyObjectByType<ItemsManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Basket"))
        {
            manager.score += value;
            manager.Score.text = "Score: " + manager.score.ToString();
            Destroy(this.gameObject, 0.5f);
        }
        
        //previously had two OnTriggerEnter2D but Unity does not read two in the same 
        if (collision.gameObject.CompareTag("Ground"))
        {
            Destroy(this.gameObject);
        }

    }

}
