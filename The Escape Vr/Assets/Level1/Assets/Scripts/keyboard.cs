using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyboard : MonoBehaviour {
	public TextMesh textHolder;
	public TextMesh keyText;
	public Collider handLeft;
	public Collider handRight;
	public TextMesh textEnd;
	public Light projectorLight;
	
	void OnTriggerEnter(Collider col) {
		if (col == handLeft || col == handRight) {
			textHolder.text += keyText.text;

			if (this.tag == "keyEnter") {
				if (textHolder.text == "PROJECTEUR") {
					textEnd.text = "Bravo !\nVous avez\nTerminer";
					projectorLight.enabled = true;
				}
					
				textHolder.text = "";
				
			} 
			
		}
	}
}
