using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInventoryDisplay : MonoBehaviour {

	public Image[] starPlaceholders;
	public Sprite hud_heartFull;
	public Sprite hud_heartEmpty;
	public void OnChangeStarTotal(int starTotal) {
		for (int i = 0; i < starPlaceholders.Length; ++i) {
			if (i < starTotal)
				starPlaceholders[i].sprite = hud_heartFull;
			else
				starPlaceholders[i].sprite = hud_heartEmpty;
			} 
	
	}
}
