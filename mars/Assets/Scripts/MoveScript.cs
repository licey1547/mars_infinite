using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour {

	public GameObject o;
	public float moveSpeed = 4f;

	void Update () {
		if(Input.GetKey(KeyCode.W)){
			o.transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
		}

		if(Input.GetKey(KeyCode.S)){
			o.transform.Translate (-Vector3.forward * moveSpeed * Time.deltaTime);
		}

		if(Input.GetKey(KeyCode.A)){
			o.transform.Translate (new Vector3(-1f, 0, 0) * moveSpeed * Time.deltaTime);
		}

		if(Input.GetKey(KeyCode.D)){
			o.transform.Translate (new Vector3(1f, 0, 0) * moveSpeed * Time.deltaTime);
		}
	}
}
