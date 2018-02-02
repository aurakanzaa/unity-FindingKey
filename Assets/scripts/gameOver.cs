using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameOver : MonoBehaviour {
	private PlayerInventoryDisplay playerInventoryDisplay;
	private int totalStars = 3;
	void Start()
	{
		playerInventoryDisplay = GetComponent < PlayerInventoryDisplay >
			();
	}
	void OnTriggerEnter2D(Collider2D hit) 
	{
		if (hit.CompareTag("Black")) {
			totalStars--;
			Destroy(hit.gameObject);
			playerInventoryDisplay.OnChangeStarTotal(totalStars);
			if (totalStars == 0) {
				Application.LoadLevel (2);
			}
		} 
	}

}
