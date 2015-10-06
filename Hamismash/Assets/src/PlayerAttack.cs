using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour {

	public GameObject projectilePrefab;
	public int projectileSpeed = 3000;
	private int coolDown;

	// Use this for initialization
	void Start () {
		coolDown = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (coolDown > 0) {
			coolDown--;
		} else {
			if (Input.GetKey(KeyCode.Space)) {
				coolDown = 80;
				shootWeb();
			}
		}
	}

	void shootWeb() {
		//Instantiate(projectilePrefab, transform.position+new Vector3(Random.Range(-2,2), 0.4f, Random.Range(-2,2)), Quaternion.identity);
		GameObject projectile = (GameObject)Instantiate(projectilePrefab, transform.position+new Vector3(0, 1, 0), Quaternion.identity);
		Rigidbody body = projectile.GetComponent<Rigidbody> ();
		body.AddForce ((transform.forward+new Vector3(0, 0.5f, 0)) * projectileSpeed);
		//body.AddForce (new Vector3(projectileSpeed, 0, 0));
	}
}
