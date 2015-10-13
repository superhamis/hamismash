using UnityEngine;
using System.Collections;

public class DestroyProjectile : MonoBehaviour {

	public GameObject splashPrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter() {
		Vector3 pos = transform.position;
		pos.y = 0;
		Instantiate (splashPrefab, pos, Quaternion.identity);
		Object.Destroy(this.gameObject);
	}



}
