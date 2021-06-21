using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    public Rigidbody rb;
    public int moveForce = 1500;
    public int sideForce = 100;
    public bool jumpEnabled = true;
    public float rotationSpeed = 50f;

    // Start is called before the first frame update
    void Start()
    {
        rb.useGravity = true;
        

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("d"))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-1*sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);   
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, moveForce * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -1 * moveForce * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space) && jumpEnabled)
        {
            rb.AddForce(0, moveForce * Time.deltaTime, 0);
        }
        if(rb.position.y < -5f)
        {
            FindObjectOfType<GameManager>().endGame();
        }
    }
}
