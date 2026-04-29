using UnityEngine;

public class CarRaycast : MonoBehaviour
{
    public Camera cam;
    public float distance = 10f;
    public CarUIManager uiManager;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, distance))
            {
                CarData car = hit.collider.GetComponent<CarData>();

                if (car != null)
                {
                    uiManager.ShowCarDetails(car);
                }
            }
        }
    }
}