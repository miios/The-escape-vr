using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowEnigma : MonoBehaviour {
	public TextMesh textHolder;
	public Collider handLeft;
	public Collider handRight;
	public GameObject keyboard;
	public GameObject[] pc;
	public Light boardLight;

	private Material material;
	private Shader pcOnMat;

	
	void Start() {
		pcOnMat = Shader.Find("Legacy Shaders/Self-Illumin/Bumped Specular");
	}
	
	void OnTriggerEnter(Collider col) {
		if (col == handLeft || col == handRight) {
			if (this.tag == "colliderLeft")
				textHolder.text += "<";
			else if (this.tag == "colliderRight")
				textHolder.text += ">";
			else {
				if (textHolder.text == ">><>>><<>>")
					allumerPc();

				textHolder.text = "";
			}
		}
	}

	void allumerPc() {
		for (int i = 0; i < pc.Length; i++)	{
			Renderer matPc = pc[i].transform.GetChild(1).GetComponent<Renderer>();
			Light lightPc = pc[i].transform.GetChild(3).GetComponent<Light>();
			boardLight.enabled = true;
			matPc.material.shader = pcOnMat;
			lightPc.enabled = true;
			keyboard.SetActive(true);
		}
	}

}
