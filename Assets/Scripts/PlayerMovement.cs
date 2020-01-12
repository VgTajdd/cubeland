using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Start is called before the first frame update
    //void Start()
    //{
    //    //Debug.Log("Hello, World!");
    //    //rb.useGravity = false;
    //    //rb.AddForce(0, 200, 500);
    //}

    // Update is called once per frame
    //void Update()
    //{
    //    rb.AddForce(0, 0, 20);
    //}

    // This method is used only to mess with physics.
    void FixedUpdate()
    {
        // Add a forward force.
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if ( Input.GetKey("d") )
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if ( Input.GetKey("a") )
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("right"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("left"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        Debug.Log(Screen.width);
        for (int i = 0; i < Input.touchCount; ++i)
        {
            //Debug.Log(Screen.width);
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                Touch touch = Input.GetTouch(i);
                Debug.Log(touch.position.x);
                //Debug.Log(Screen.width);
                if (touch.position.x < Screen.width/2)
                {
                    rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                }
                else
                {
                    rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                }
            }
        }

        if (rb.position.y<-1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
