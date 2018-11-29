using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowEnigma : MonoBehaviour {
	public TextMesh textHolder;
	public Collider handLeft;
	public Collider handRight;
	
	void OnTriggerEnter(Collider col) {
		if (col == handLeft || col == handRight) {
			if (this.tag == "colliderLeft")
				textHolder.text += "< ";
			else if (this.tag == "colliderRight")
				textHolder.text += "> ";
			else
				textHolder.text = "";
		}
	}
}
