using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	public float speed = 0.5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W)) {
			transform.Translate(speed*Vector3.forward);
		}
		if (Input.GetKey(KeyCode.A)) {
			transform.Translate(speed*Vector3.left);
		}
		if (Input.GetKey(KeyCode.S)) {
			transform.Translate(speed*Vector3.back);
		}
		if (Input.GetKey(KeyCode.D)) {
			transform.Translate(speed*Vector3.right);
		}
	}
}
