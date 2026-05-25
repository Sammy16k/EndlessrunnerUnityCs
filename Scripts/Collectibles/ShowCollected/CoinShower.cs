using UnityEngine;
using UnityEngine.UI;

public class CoinShower : MonoBehaviour
{
    public static int coinCount;
    public GameObject coinCountDisplay;

    void Update()
    {
        coinCountDisplay.GetComponent<Text>().text = "  " + coinCount;
    }
}
