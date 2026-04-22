using UnityEngine;

public class CarUIManager : MonoBehaviour
{
    public GameObject carPanel;

    public void HideCarDetails()
    {
        carPanel.SetActive(false);
    }
}