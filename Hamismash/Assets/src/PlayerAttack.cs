using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour {

	public GameObject projectilePrefab;
	public int projectileSpeed = 300;
	private bool charging;
	private PlayerState playerState;

	// Use this for initialization
	void Start () {
		playerState = PlayerState.Instance;
		playerState.Charge = 0;
		playerState.CoolDown = 0;
		charging = false;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (charging) {
			if (Input.GetKey(KeyCode.Space)) {
				playerState.Charge+=2;
				if (playerState.Charge > 100) {
					playerState.Charge = 100;
				}
				Debug.Log(playerState.Charge);
			} else {
				shootWeb(playerState.Charge);
				playerState.Charge = 0;
				charging = false;
				playerState.CoolDown = 100;
			}
		} else if (playerState.CoolDown > 0) {
			playerState.CoolDown-=2;
		} else {
			if (Input.GetKey(KeyCode.Space)) {
				charging = true;
			}
		}
	}


	void shootWeb(int force) {
		//Instantiate(projectilePrefab, transform.position+new Vector3(Random.Range(-2,2), 0.4f, Random.Range(-2,2)), Quaternion.identity);
		GameObject projectile = (GameObject)Instantiate(projectilePrefab, transform.position+new Vector3(0, 1, 0), Quaternion.identity);
		Rigidbody body = projectile.GetComponent<Rigidbody> ();
		body.AddForce ((transform.forward+new Vector3(0, 0.5f, 0)) * (200+(force*2)));
		//body.AddForce (new Vector3(projectileSpeed, 0, 0));
	}
}
