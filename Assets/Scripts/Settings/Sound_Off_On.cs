using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sound_Off_On : MonoBehaviour {

	public GameObject switcher;
	public GameObject Sounds_Bg;

	public Sprite sprite_on;
	public Sprite sprite_off;

	private bool Switcher;
	void OnMouseDown()
	{
		if (Switcher == true) 
		{
			switcher.GetComponent<Image> ().sprite = sprite_on;
			Sounds_Bg.GetComponent<AudioSource> ().Play();
			Switcher = false;
		}
		else
		{
			switcher.GetComponent<Image> ().sprite = sprite_off;
			Sounds_Bg.GetComponent<AudioSource> ().Pause();
			Switcher = true;
		}
	}
}
