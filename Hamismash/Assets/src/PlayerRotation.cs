using UnityEngine;
using System.Collections;

public class PlayerRotation : MonoBehaviour {

	public GameObject targetObject;
	//private Transform mouse;

	// Use this for initialization
	void Start () {
		//mouse = new Transform ();
	}
	
	// Update is called once per frame
	void Update () {

		Plane playerPlane = new Plane(Vector3.up, transform.position);
		
		// Generate a ray from the cursor position
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

		float hitdist = 0.0f;

		if (playerPlane.Raycast (ray, out hitdist)) {
			Vector3 targetPoint = ray.GetPoint(hitdist);
			Quaternion targetRotation = Quaternion.LookRotation(targetPoint - transform.position);
			transform.rotation = targetRotation;
		}


		//mouse.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		//transform.LookAt(targetObject.transform);
		//transform.LookAt(Camera.main.ScreenToWorldPoint(Input.mousePosition));
		transform.Rotate (0, 90, 90);
	}
}
