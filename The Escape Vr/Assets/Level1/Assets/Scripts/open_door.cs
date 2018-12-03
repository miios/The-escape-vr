using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class open_door : MonoBehaviour {
	public Collider KeyCollider;
	public GameObject Key;
	void OnTriggerEnter(Collider col) {
		if (col == KeyCollider)
			this.transform.Rotate(0, 90, 0);
	}
}
