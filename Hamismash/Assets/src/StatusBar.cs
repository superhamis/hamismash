using UnityEngine;
using System.Collections;

public class StatusBar : MonoBehaviour {

	public RectTransform filler;
	public float healthPercentage;
	private float backgroundWidth;

	// Use this for initialization
	void Start () {
		RectTransform background = GetComponent<RectTransform> ();
		backgroundWidth = background.sizeDelta.x;

	}
	
	// Update is called once per frame
	void Update () {
		filler.SetSizeWithCurrentAnchors (RectTransform.Axis.Horizontal, backgroundWidth * healthPercentage);
		//filler.sizeDelta = new Vector2 (backgroundWidth * healthPercentage, filler.sizeDelta.y);
		//filler.anchoredPosition = new Vector2 (38.2f, 0.0f);
	}
}
