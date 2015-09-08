using UnityEngine;
using System.Collections;

public class DestroyHouse : MonoBehaviour
{

	public int hp = 100;
	private MeshFilter meshFilter;
	public Mesh destroyedMesh;

	// Use this for initialization
	void Start ()
	{
		hp = 100;
		meshFilter = GetComponent<MeshFilter> ();
	}
	
	// Update is called once per frame
	void Update ()
	{

	}

	void OnTriggerEnter (Collider col)
	{

		if (col.gameObject.name == "Capsule") {
			meshFilter.mesh = destroyedMesh;
		}
	}

}
