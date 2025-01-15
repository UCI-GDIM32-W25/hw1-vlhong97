using UnityEngine;
using TMPro;

public class PlantCountUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _plantedText;
    [SerializeField] private TMP_Text _remainingText;

    public void UpdateSeeds (int seedsLeft, int seedsPlanted)
    {
        // check on console if the PlantCountUI script got the data of the amount of seeds left/planted
        Debug.Log("PlantCountUI has " + seedsLeft);
        Debug.Log("PlantCountUI has " + seedsPlanted);

        // update UI for amount of seeds planted.
        _plantedText.text = seedsPlanted.ToString();

        // update UI for amount of seeds left in inventory. 
        _remainingText.text = seedsLeft.ToString();
    }
}