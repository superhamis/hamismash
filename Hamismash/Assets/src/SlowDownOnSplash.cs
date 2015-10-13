using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SlowDownOnSplash : MonoBehaviour {

	public float defaultSpeed = 1.0f;
	public float speed;
	private List<Collider> collidingSplashes;

	// Use this for initialization
	void Start () {
		this.collidingSplashes = new List<Collider>();
		this.speed = defaultSpeed;
	}

	void OnTriggerEnter (Collider col)
	{
		//When a splash hits us, set speed to a reduced value
		if (col.gameObject.name.Contains ("Splash")) {
			this.speed = this.defaultSpeed / 4;
			this.collidingSplashes.Add(col);
		}
	}

	void Update () {
		//Remove all null splashes (ie. splashes that have been destroyed before trigger exit) from the list 
		collidingSplashes.RemoveAll(item => item == null);
		//When we no longer collide with any splash, restore default speed
		if (collidingSplashes.Count == 0) {
			this.speed = this.defaultSpeed;
		}
	}
	
	void OnTriggerExit (Collider col)
	{
		if (col.gameObject.name.Contains ("Splash")) {
			this.collidingSplashes.Remove(col);
		}
	}
}
