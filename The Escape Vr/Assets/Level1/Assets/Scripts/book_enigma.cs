using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class book_enigma : MonoBehaviour {

	public GameObject[] Books;
	public Material[] textures;
	int count_books = 0;
	public Collider handLeft;
	public Collider handRight;
	public GameObject Paper;
	public GameObject keypad;
	public Light SuccessLight;
	public string[] Color;

	void OnTriggerEnter(Collider col) {
		if (col == handLeft || col == handRight) {
			count_books = (count_books != 3) ? count_books + 1 : 0;
			GetComponent<Renderer>().material = textures[count_books];
			this.tag = Color[count_books];
			check_win(count_books);
		}
	}

	void check_win(int nb) {

		if (Books[0].tag == "blue" && Books[1].tag == "green" && Books[2].tag == "yellow") {
			Paper.SetActive(true);
			keypad.SetActive(true);
			SuccessLight.enabled = true;
		}
	}
}
