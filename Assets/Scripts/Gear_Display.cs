using UnityEngine;
using UnityEngine.UI;
public class Gear_Display : MonoBehaviour
{
    public Car driveScript;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "speed rating: " + driveScript.gear.ToString("0");
    }
}
