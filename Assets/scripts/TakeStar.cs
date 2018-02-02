using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace scripts { 
public class TakeStar : MonoBehaviour {

	public Image keyImage;
	private int totalKey = 10;
	public Text keyText;
	public Sprite iconKey;
	public Sprite iconNoKey;
	private bool carryingKey = false; 
  
	void OnTriggerEnter2D(Collider2D hit) 
	{
        if (hit.CompareTag("key")) {
            totalKey--;
            carryingKey = true;
            UpdateStarImage();
            Destroy(hit.gameObject);
            string keyMessage = ": " + totalKey;
            keyText.text = keyMessage;
            if (totalKey < 1)
            {
                Application.LoadLevel(1);
                    MenuActions.restart += 1;
            }
		}

        if (hit.CompareTag("jatuh"))
        {
            Application.LoadLevel(2);
        }

	}
	private void UpdateStarImage() {
		if (carryingKey) {
			keyImage.sprite = iconKey;
	
		} else {
			keyImage.sprite = iconNoKey;

		}
	} 

}
}
