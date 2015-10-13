using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FleeFromHouse : MonoBehaviour {

	private GameObject safe;
	public int numberOfSafePoints = 7;
	private SlowDownOnSplash speedBehaviour;

	void Start () {
		safe = chooseRandomSafeArea ();
		speedBehaviour = this.gameObject.GetComponent<SlowDownOnSplash> ();
	}

	void FixedUpdate () {
		transform.position = Vector3.MoveTowards(transform.position, safe.transform.position, speedBehaviour.speed);
	}

	private GameObject chooseRandomSafeArea() {
		int luku = ((int)Random.Range (0, numberOfSafePoints))+1;
		return GameObject.Find ("SafeZone"+luku);
	}

	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.name.Contains ("SafeZone")) {
			Object.Destroy(this.gameObject);
		}
	}
}
