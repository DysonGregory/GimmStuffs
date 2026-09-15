using UnityEngine;
using TMPro;

public class TreasureManager : MonoBehaviour
{
    public int treasureCount = 0;
    public TextMeshProUGUI treasureText;

    public void CollectTreasure()
    {
        treasureCount++;
        treasureText.text = "Treasure: " + treasureCount;
    }
}
