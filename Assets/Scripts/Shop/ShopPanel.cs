using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopPanel : MonoBehaviour {

	public GameObject GamePanel;
	public GameObject BuyPanel_0;
	public GameObject BuyPanel_1;
	public GameObject BuyPanel_2;
	public GameObject BuyPanel_3;
	public GameObject BuyPanel_4;
	public GameObject Shoppanel;
	public GameObject MenuPanel;
	public GameObject SettingsPanel;
	public Image SettingsImag;
	public Sprite SettingsNotActiv;

	void OnMouseDown()
	{
		SettingsImag.GetComponent<Image> ().sprite = SettingsNotActiv;
		SettingsPanel.SetActive (false);
		BuyPanel_0.SetActive (false);
		BuyPanel_1.SetActive (false);
		BuyPanel_2.SetActive (false);
		BuyPanel_3.SetActive (false);
		BuyPanel_4.SetActive (false);
		GamePanel.SetActive (false);
		MenuPanel.SetActive (false);
		Shoppanel.SetActive (true);
	}

}
