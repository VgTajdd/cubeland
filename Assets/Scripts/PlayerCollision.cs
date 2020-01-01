using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("We hit something");
        //Debug.Log(collision.collider.name);
        if (collision.collider.tag == "Obstacle")
        {
            Debug.Log("We hit an obstable");
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
