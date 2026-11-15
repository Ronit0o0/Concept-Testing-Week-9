using UnityEngine;

public class Concept2Type2D : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    public float timer;
    public float timerGoal;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Kinematic;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime); 
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Entered Trigger");
        rb.bodyType = RigidbodyType2D.Static;
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("Inside Trigger");
        timer += Time.deltaTime;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Outside Trigger");
        if (timer > timerGoal)
        {
            Debug.Log("Timer Goal Reached");
            rb.bodyType = RigidbodyType2D.Kinematic;
        }
    }

}
