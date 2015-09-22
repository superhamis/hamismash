using UnityEngine;
using System.Collections;

public class EscapedPeasant : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider col)
	{
		//if (col.gameObject.name.Contains ("SafeZone")) {
			Object.Destroy(this.gameObject);
		//}
	}
}

