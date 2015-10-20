using UnityEngine;
using System.Collections;

public class PlayerState
{
	private static PlayerState instance;
	public static PlayerState Instance
	{
		get {
			if (instance == null)
			{
				instance = new PlayerState();
			}
			return instance;
		}
	}
	
	public int Stamina { get; set; }
	public int Health { get; set; }
	public int Charge { get; set; }
	public int CoolDown { get; set; }
}
