using UnityEngine;

public class Concept1Contraints2D : MonoBehaviour
{
    public Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Grab Componenet from Game Object through script
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //This will freeze all rotation of the Game Object
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;

        //This will freeze translation of the Game Object on the y axis
        //rb.constraints = RigidbodyConstraints2D.FreezePositionY;

        //This will freeze all rotation of the Game Object
        //rb.constraints = RigidbodyConstraints2D.FreezeRotation;

        //This will freeze translation of the Game Object on the x axis
        //rb.constraints = RigidbodyConstraints2D.FreezePositionX;

        //This will freeze all movement and rotation making the object static and a "impnetrable wall"
        //rb.constraints = RigidbodyConstraints2D.FreezeAll;

        //This will freeze nothing
        //rb.constraints = RigidbodyConstraints2D.None;
    }
}
