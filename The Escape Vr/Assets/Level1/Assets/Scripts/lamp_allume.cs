using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lamp_allume : MonoBehaviour {

	public BoxCollider Box1;
	public SphereCollider LeftHands;
	public SphereCollider RightHands;
	// Use this for initialization
	public Light[] OfficeLight;
	public GameObject Paper;
	void OnTriggerEnter(Collider col) {
		if (col == LeftHands || col == RightHands) {
			for (int i = 0; i < OfficeLight.Length; i++)
				OfficeLight[i].enabled = true;
			Paper.SetActive(true);
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}