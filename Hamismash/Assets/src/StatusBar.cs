using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StatusBar : MonoBehaviour {

	public RectTransform filler;
	public Text healthText;
	private float backgroundWidth;
	private PlayerState playerState;

	// Use this for initialization
	void Start () {
		RectTransform background = GetComponent<RectTransform> ();
		backgroundWidth = background.sizeDelta.x;
		playerState = PlayerState.Instance;
		playerState.Health = 100;
	}
	
	// Update is called once per frame
	void Update () {
		filler.SetSizeWithCurrentAnchors (RectTransform.Axis.Horizontal, backgroundWidth * playerState.Health/100);
		healthText.text = "Health: " + playerState.Health;
		if (playerState.Health < 1) {
			Application.LoadLevel(0);
		}
	}
}
