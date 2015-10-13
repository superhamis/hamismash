using UnityEngine;
using System.Collections;

public class ProjectileSplash : MonoBehaviour {

	public int timeToLive;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		this.timeToLive--;

		if (this.timeToLive < 1) {
			Destroy(this.gameObject);
		}
	}
}
