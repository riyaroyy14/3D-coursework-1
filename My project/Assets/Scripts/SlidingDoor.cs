using UnityEngine;

public class SlidingDoor : MonoBehaviour
{
    public Transform player;
    public float openDistance = 5f;
    public float slideAmount = 3f;
    public float speed = 2f;

    public bool slideLeft = false; // 👈 important

    private Vector3 closedPosition;
    private Vector3 openPosition;

    void Start()
    {
        closedPosition = transform.position;

        //if (slideLeft)
           // openPosition = transform.position - transform.right * slideAmount;
        //else
            //openPosition = transform.position + transform.right * slideAmount;

        if (slideLeft)
            openPosition = transform.position + new Vector3(0, 0, -slideAmount );
        else
            openPosition = transform.position + new Vector3( 0, 0, slideAmount );

    }

    void Update()
    {
        float distance = Vector3.Distance(player.position, transform.position);

        if (distance < openDistance)
        {
            transform.position = Vector3.Lerp(transform.position, openPosition, Time.deltaTime * speed);
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, closedPosition, Time.deltaTime * speed);
        }
    }
}