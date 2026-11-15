using UnityEngine;

public class Concept3AddForceAtPosition : MonoBehaviour
{
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //This is where the force will be added and how strong it will be
       Vector2 forceAdded = new Vector2(-2, 0);
        
        //This will apply the force in world space at and offset from the ogirinal position of the game object
       Vector2 forcePosition = (Vector2)transform.position + new Vector2(0, 1);

        //Everything together along with the type force that is applied
       rb.AddForceAtPosition(forceAdded, forcePosition, ForceMode2D.Force);
    }
}