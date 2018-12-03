using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pic_fire : MonoBehaviour {

	public Texture textures;
	public Collider lamp1;
	public Collider lamp2;
	void OnTriggerEnter(Collider col) {
		if (col == lamp1 || col == lamp2)
			GetComponent<Renderer>().material.mainTexture = textures;
	}
}