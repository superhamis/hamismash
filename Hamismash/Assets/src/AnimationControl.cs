using UnityEngine;
using System.Collections;

public class AnimationControl : MonoBehaviour
{
    Animator anim;
    public float move;
	// Use this for initialization
	void Start () {
	anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        anim.SetFloat("Speed", move);
        if (Input.GetKey(KeyCode.W))
        {
            move = 1;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            move = 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            move = 1;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            move = 1;
        }
        else
        {
            move = 0;
        }
    }
}
