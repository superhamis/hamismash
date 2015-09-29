using UnityEngine;
using System.Collections;

public class DestroyHouse : MonoBehaviour
{

	public GameObject peasantPrefab;

	public int hp = 100;
	private MeshFilter meshFilter;
	private bool isDestroyed;
	public Mesh destroyedMesh;

	// Use this for initialization
	void Start ()
	{
		isDestroyed = false;
		hp = 100;
		meshFilter = GetComponent<MeshFilter> ();
	}
	
	// Update is called once per frame
	void Update ()
	{

	}

	void OnTriggerEnter (Collider col)
	{
		if (this.isDestroyed) {
			return;
		}
		if (col.gameObject.name == "Spider") {
			this.isDestroyed = true;
			destroyed();
		}
	}

	private void destroyed() {
		meshFilter.mesh = destroyedMesh;
		for (int i = 0; i<6; i++) {
			Object peasant = Instantiate(peasantPrefab, transform.position+new Vector3(Random.Range(-2,2), 0.4f, Random.Range(-2,2)), Quaternion.identity);

		}
	}

}
