using UnityEngine;
using System.Collections;

public class SpawnBuildings : MonoBehaviour {

	public GameObject buildingPrefab;

	// Use this for initialization
	void Start () {
		for (int i = 0; i<10; i++) {
			Instantiate(buildingPrefab, new Vector3(Random.Range(-20,20), 0, Random.Range(-20,20)), Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
		//if (Input.GetKey(KeyCode.Space)) {
//			gameObject.AddComponent<SpawnBuildings>();
			//Instantiate(buildingPrefab, new Vector3(Random.Range(-20,20), 0, Random.Range(-20,20)), Quaternion.identity);
		//}
	}
}
