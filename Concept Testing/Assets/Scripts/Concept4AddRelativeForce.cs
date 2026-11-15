using UnityEngine;

public class Concept4AddRelativeForce : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        //This moves the game object up on the y axis
        rb.AddRelativeForce(Vector2.up * speed, ForceMode2D.Force);
    }
}
