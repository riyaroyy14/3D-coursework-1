using UnityEngine;

public class CarClickHandler : MonoBehaviour
{
    public GameObject carPanel;

    void Update()
    {
       if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.root == transform)
                {
                    Debug.Log("Car Clicked!");
                    carPanel.SetActive(true); 

                    Debug.Log("Panel Active: " + carPanel.activeSelf);
                }
            }
        } 
    }
}