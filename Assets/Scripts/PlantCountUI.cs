using UnityEngine;
using TMPro;

public class PlantCountUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _plantedText;
    [SerializeField] private TMP_Text _remainingText;

    public void UpdateSeeds (int seedsLeft, int seedsPlanted)
    {
        //_text.text = "Points: " + points.ToString();

        _plantedText.text = seedsPlanted.ToString();

        _remainingText.text = seedsLeft.ToString();
    }
}