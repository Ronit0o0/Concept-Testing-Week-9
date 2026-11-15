using UnityEngine;

public class StopRotation : MonoBehaviour
{
    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //This grabs the componenet from the game object rhough script
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        //This will freeze all rotation of the game object
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;

        //This will freeze all rotation on the Y axis
        //rb.constraints = RigidbodyConstraints2D.FreezePositionY;

        ////This will freeze all rotation on the X axis
        //rb.constraints = RigidbodyConstraints2D.FreezePositionX;

        ////This will freeze all translation and rotation of the game object
        //rb.constraints = RigidbodyConstraints2D.FreezeAll;

        ////This will freeze nothing
        //rb.constraints = RigidbodyConstraints2D.None;

        ////This will freeze the postition but not the rotation of the gam object
        //rb.constraints = RigidbodyConstraints2D.FreezePosition;
    }
}
