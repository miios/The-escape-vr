using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keypad : MonoBehaviour {

	public GameObject Chest;
	public GameObject Key;
	public TextMesh textHolder;
	public TextMesh keyText;
	public Collider handLeft;
	public Collider handRight;
	public Light SuccessLight;
	
	void OnTriggerEnter(Collider col) {
		if (col == handLeft || col == handRight) {
			textHolder.text += keyText.text;
			if (this.tag == "keyEnter") {
				if (textHolder.text == "1594") {
					SuccessLight.enabled = true;
					Chest.SetActive(false);
					Key.SetActive(true);
				}
				textHolder.text = "";
			} 
		
		}
	}
}
