using UnityEngine;
using System.Collections;

public class WeaponBar : MonoBehaviour {

	public RectTransform chargeFiller;
	public RectTransform cooldownFiller;
	private float backgroundWidth;
	private PlayerState playerState;

	// Use this for initialization
	void Start () {
		RectTransform background = GetComponent<RectTransform> ();
		backgroundWidth = background.sizeDelta.x;
		playerState = PlayerState.Instance;
	}
	
	// Update is called once per frame
	void Update () {
		chargeFiller.SetSizeWithCurrentAnchors (RectTransform.Axis.Horizontal, backgroundWidth * playerState.Charge/100);
		cooldownFiller.SetSizeWithCurrentAnchors (RectTransform.Axis.Horizontal, backgroundWidth * playerState.CoolDown/100);
		//filler.sizeDelta = new Vector2 (backgroundWidth * healthPercentage, filler.sizeDelta.y);
		//filler.anchoredPosition = new Vector2 (38.2f, 0.0f);
	}
}
