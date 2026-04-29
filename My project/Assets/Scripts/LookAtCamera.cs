using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    public Transform cam;

    void Update()
    {
        transform.LookAt(cam);
    }
}