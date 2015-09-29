using UnityEngine;
using System.Collections;

public class AttackPlayer : MonoBehaviour {

	public GameObject player;
	public float speed;
	public float viewDistance;
	public float attackDistance;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		turnTowardPlayer ();
		float distance = distanceToPlayer ();
		if (distance < attackDistance) {
			attackPlayer ();
		} else if (distance < viewDistance) {
			moveForward();
		}
	}

	private float distanceToPlayer() {
		return Vector3.Distance (player.transform.position, transform.position);
	}

	private void turnTowardPlayer() {
		Vector3 targetPoint = player.transform.position;
		Quaternion targetRotation = Quaternion.LookRotation(targetPoint - transform.position);
		transform.rotation = targetRotation;
	}

	private void moveForward() {
		transform.Translate (Vector3.forward*speed*Time.deltaTime);
	}

	private void attackPlayer() {

	}
}
