using UnityEngine;
using TMPro;

public class PlantCountUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _plantedText;
    [SerializeField] private TMP_Text _remainingText;
    private string _remaining = "Seeds Remaining: ";
    private string _planted = "Seeds Planted: ";

    public void UpdateSeeds (int seedsLeft, int seedsPlanted)
    {
        _remainingText.text = _remaining + seedsLeft;
        _plantedText.text = _planted + seedsPlanted;
    }
}