using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    public Text starText;
    private int totalKey = 10;
    void Start()
    {
        UpdateStarText();
    }
    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.CompareTag("key"))
        {
            totalKey--;
            UpdateStarText();
            Destroy(hit.gameObject);
        }
    }
    private void UpdateStarText()
    {
        string starMessage = ": " + totalKey;
        starText.text = starMessage;
    }
}