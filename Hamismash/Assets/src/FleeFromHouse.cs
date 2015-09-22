using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FleeFromHouse : MonoBehaviour {

	private GameObject safe;
	public int numberOfSafePoints = 7;
	public float speed = 1.0f;

	// Use this for initialization
	void Start () {
		int luku = ((int)Random.Range (0, numberOfSafePoints))+1;
		safe = GameObject.Find ("SafeZone"+luku);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.MoveTowards(transform.position, safe.transform.position, speed*Time.deltaTime);
	}
}
