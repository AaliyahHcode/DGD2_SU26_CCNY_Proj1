using UnityEngine;

public class Coin : MonoBehaviour
{
    public float lifetime = 3f;
    public float value = 1f;

    public PlayerWASD targetPlayer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        targetPlayer = PlayerWASD.THEplayer;
    }

    // Update is called once per frame
    void Update()
    {
        lifetime -= Time.deltaTime;
        if(lifetime < 0f)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            //we can use GetComponent to find our own scripts and send data
            //PlayerWASD pS = collision.gameObject.GetComponent<PlayerWASD>();
            //Debug.Log("we found the player");
            //ps.AddScore(value);

            collision.gameObject.SendMessage("AddScore", value);
            Destroy(this.gameObject);
        }
    }
}
