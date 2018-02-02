using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetKey : MonoBehaviour {

    public Text KeyText;
    private int totalKey = 10;

    void Start()
    {
        UpdateKeyText();
    }

    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.CompareTag("Key"))
        {
            totalKey--;
            UpdateKeyText();
            Destroy(hit.gameObject);
        }
    }

    private void UpdateKeyText()
    {
        string keyMessage = "X " + totalKey;
        KeyText.text = keyMessage;
    }
}
