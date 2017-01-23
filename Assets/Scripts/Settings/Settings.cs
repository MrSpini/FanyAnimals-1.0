using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour {

	public GameObject settings;
	public GameObject GamePanel;
	public GameObject MenuPanel;
	public GameObject ShopPanel;
	public Image SettingsImag;
	public Sprite SettingsActiv;
	public Sprite SettingsNotActiv;

	void OnMouseUp()
	{
		if(settings.activeInHierarchy==false){
		settings.SetActive (true);
			SettingsImag.GetComponent<Image> ().sprite = SettingsActiv;
		GamePanel.SetActive (false);
		MenuPanel.SetActive (false);
			ShopPanel.SetActive (false);
		}
		else
		{
			settings.SetActive (false);
			SettingsImag.GetComponent<Image> ().sprite = SettingsNotActiv;
			GamePanel.SetActive (true);
			MenuPanel.SetActive (true);
		}
	}
}
