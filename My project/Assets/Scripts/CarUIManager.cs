using UnityEngine;
using TMPro;

public class CarUIManager : MonoBehaviour
{
    public GameObject panel;
    public TextMeshProUGUI detailsText;

    public void ShowCarDetails(CarData car)
    {
        panel.SetActive(true);

        panel.transform.position = car.transform.position + new Vector3(0, 2f, 0);

        panel.transform.rotation = Quaternion.LookRotation(
        panel.transform.position - Camera.main.transform.position
    );

        detailsText.text =
            "Car Name: " + car.carName + "\n" +
            "Price: " + car.price + "\n" +
            "Speed: " + car.speed + "\n" +
            "Engine: " + car.engine + "\n" +
            "Color: " + car.color + "\n" +
            "Type: " + car.type;
    }

    public void HideCarDetails()
    {
        panel.SetActive(false);
    }
}



