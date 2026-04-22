using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public Transform player;
    public float openDistance = 5f;
    public float openAngle = -90f;
    public float speed = 2f;

    private Quaternion closedRotation;
    private Quaternion openRotation;

    void Start()
    {
        closedRotation = transform.rotation;
        openRotation = Quaternion.Euler(0, openAngle, 0) * closedRotation;
    }

    void Update()
    {
        float distance = Vector3.Distance(player.position, transform.position);

        if (distance < openDistance)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, openRotation, Time.deltaTime * speed);
        }
        else
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, closedRotation, Time.deltaTime * speed);
        }
    }
}