using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextIcons : MonoBehaviour {

	public GameObject switcher;

	public Sprite sprite_on;
	public Sprite sprite_off;

	private bool Switcher;
	void OnMouseDown()
	{
		if (Switcher == true) 
		{
			switcher.GetComponent<Image> ().sprite = sprite_on;
			Switcher = false;
		}
		else
		{
			switcher.GetComponent<Image> ().sprite = sprite_off;
			Switcher = true;
		}
	}
}
