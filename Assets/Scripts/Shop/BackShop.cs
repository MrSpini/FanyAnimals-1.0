using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackShop : MonoBehaviour {
	
	public GameObject Shop;
	public GameObject GamePanel;
	public GameObject MenuPanel;


	void OnMouseUp()
	{
		
		Shop.SetActive (false);
		GamePanel.SetActive (true);
		MenuPanel.SetActive (true);
		
	}
}
