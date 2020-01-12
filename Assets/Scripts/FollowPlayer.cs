using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(player.position);
        transform.position = player.position + offset;
        transform.localEulerAngles = new Vector3(0, transform.localEulerAngles.y, player.position.x);
    }
}
