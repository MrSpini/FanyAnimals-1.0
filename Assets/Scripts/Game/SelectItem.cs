using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectItem : MonoBehaviour {

	public GameObject item;
	public GameObject Imag;
	public GameObject MassagPanel;
	public GameObject MenuPanel;
	public GameObject GamePanel;
	public GameObject text;
	public GameObject Settings;

	public GameObject switcherText;

	public AnimationClip Anim1;
	public AnimationClip Anim2;
	public AnimationClip Anim3;
	public AnimationClip Anim4;
	public AnimationClip Anim5;
	public AnimationClip Anim6;
	public AnimationClip Anim7;
	public AnimationClip Anim8;
	public AnimationClip Anim9;
	public AnimationClip Anim10;
	public AnimationClip Anim11;
	public AnimationClip Anim12;
	public AnimationClip OpOp;

	public AnimationClip Item;

	private TextIcons TextIcons=new TextIcons();
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown()
	{item.SetActive (false);
			item.GetComponent<Animator> ().Play (Item.name);
		item.SetActive (true);
	}

	void OnMouseUp() 
	{
		MassagPanel.SetActive (true);
		switch(item.GetComponent<Image>().name.ToString())
		{
		case "Image0":
			MassagPanel.GetComponent<Animator> ().Play (Anim1.name);
			break;
		case "Image1":
			MassagPanel.GetComponent<Animator> ().Play (Anim2.name);
			break;
		case "Image2":
			MassagPanel.GetComponent<Animator> ().Play (Anim3.name);
			break;
		case "Image3":
			MassagPanel.GetComponent<Animator> ().Play (Anim4.name);
			break;
		case "Image4":
			MassagPanel.GetComponent<Animator> ().Play (Anim5.name);
			break;
		case "Image5":
			MassagPanel.GetComponent<Animator> ().Play (Anim6.name);
			break;
		case "Image6":
			MassagPanel.GetComponent<Animator> ().Play (Anim7.name);
			break;
		case "Image7":
			MassagPanel.GetComponent<Animator> ().Play (Anim8.name);
			break;
		case "Image8":
			MassagPanel.GetComponent<Animator> ().Play (Anim9.name);
			break;
		case "Image9":
			MassagPanel.GetComponent<Animator> ().Play (Anim10.name);
			break;
		case "Image10":
			MassagPanel.GetComponent<Animator> ().Play (Anim11.name);
			break;
		case "Image11":
			MassagPanel.GetComponent<Animator> ().Play (Anim12.name);
			break;
		}

		GamePanel.SetActive (false);
		Settings.SetActive (false);
		MenuPanel.SetActive (false);
		text.GetComponent<Text>().text = item.GetComponent<Image>().sprite.name.ToString();
		Imag.GetComponent<Image> ().sprite = item.GetComponent<Image> ().sprite;
		if (switcherText.GetComponent<Image> ().sprite.name.ToString () != "switch_on") {
			text.SetActive (false);
		} else {
			text.SetActive (true);
		}
	}
}
