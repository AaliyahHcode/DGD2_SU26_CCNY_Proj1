using UnityEngine;

public class BasketPlayer : MonoBehaviour
{
    public Rigidbody2D RB;
    public float Speed = 5f;

    // Update is called once per frame
    void Update()
    {
        Vector2 vel = Vector2.zero;

        if (Input.GetKey(KeyCode.RightArrow)) vel.x = Speed;
        if (Input.GetKey(KeyCode.LeftArrow)) vel.x = -Speed;
        if (Input.GetKey(KeyCode.UpArrow)) vel.y = Speed;
        if (Input.GetKey(KeyCode.DownArrow)) vel.y = -Speed;

        RB.linearVelocity = vel;
    }
}
