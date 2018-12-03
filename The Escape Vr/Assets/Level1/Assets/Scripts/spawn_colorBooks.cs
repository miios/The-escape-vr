using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_colorBooks : MonoBehaviour {

	public Collider[] Books;
	public bool[] count;
	public GameObject next_enigme;

	void Start() {
		count = new bool[3];
	}

	void OnTriggerEnter (Collider col) {
    	if (Books[0] == col && count[0] == false)
			count[0] = true;
		if (Books[1] == col && count[1] == false)
			count[1] = true;
		if (Books[2] == col && count[2] == false)
			count[2] = true;

		if (count[0] && count[1] && count[2])
			next_enigme.SetActive(true);
		Debug.Log("prout---------");
	}
}
