using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyCollection : MonoBehaviour {

	public  GameObject collection_1;
	public  GameObject collection_2;
	public  GameObject collection_3;
	public  GameObject collection_4;
	public  GameObject collection_5;

	public  GameObject Panelcollection_1;
	public  GameObject Panelcollection_2;
	public  GameObject Panelcollection_3;
	public  GameObject Panelcollection_4;
	public  GameObject Panelcollection_5;

	public  GameObject Collection_1;
	public  GameObject Collection_2;
	public  GameObject Collection_3;
	public  GameObject Collection_4;
	public  GameObject Collection_5;
	public GameObject[] imag=new GameObject[12];

	// Use this for initialization
	private void Start () 
	{
		PurchaseManager.OnPurchaseNonConsumable+= PurchaseManager_OnPurchaseNonConsumable;
		if (PurchaseManager.CheckBuyState ("collection_1")==true) 
		{
			collection_1.GetComponent<SelectCollection> ().Shop = true;
			Panelcollection_1.SetActive (false);
			for (int i = 0; i < imag.Length; i++) 
			{
				imag[i].GetComponent<Image> ().color = new Color32 (255, 255, 255, 255);
				imag [i].GetComponent<BoxCollider2D> ().size = new Vector2(110,110);
				Collection_1.GetComponent<Image> ().color = new Color32 (255, 255, 255, 255);
			}
		}
		if (PurchaseManager.CheckBuyState ("collection_2")==true) 
		{
			collection_2.GetComponent<SelectCollection>().Shop=true;
			Panelcollection_2.SetActive (false);
			for (int i = 0; i < imag.Length; i++) 
			{
				imag[i].GetComponent<Image> ().color = new Color32 (255, 255, 255, 255);
				imag [i].GetComponent<BoxCollider2D> ().size = new Vector2(110,110);
				Collection_2.GetComponent<Image> ().color = new Color32 (255, 255, 255, 255);
			}
		}
		if (PurchaseManager.CheckBuyState ("collection_3")==true) 
		{
			collection_3.GetComponent<SelectCollection>().Shop=true;
			Panelcollection_3.SetActive (false);
			for (int i = 0; i < imag.Length; i++) 
			{
				imag[i].GetComponent<Image> ().color = new Color32 (255, 255, 255, 255);
				imag [i].GetComponent<BoxCollider2D> ().size = new Vector2(110,110);
				Collection_3.GetComponent<Image> ().color = new Color32 (255, 255, 255, 255);
			}
		}
		if (PurchaseManager.CheckBuyState ("collection_4")==true) 
		{
			collection_4.GetComponent<SelectCollection>().Shop=true;
			Panelcollection_4.SetActive (false);
			for (int i = 0; i < imag.Length; i++) 
			{
				imag[i].GetComponent<Image> ().color = new Color32 (255, 255, 255, 255);
				imag [i].GetComponent<BoxCollider2D> ().size = new Vector2(110,110);
				Collection_4.GetComponent<Image> ().color = new Color32 (255, 255, 255, 255);
			}
		}
		if (PurchaseManager.CheckBuyState ("collection_5")==true) 
		{
			collection_5.GetComponent<SelectCollection>().Shop=true;
			Panelcollection_5.SetActive (false);
			for (int i = 0; i < imag.Length; i++) 
			{
				imag[i].GetComponent<Image> ().color = new Color32 (255, 255, 255, 255);
				imag [i].GetComponent<BoxCollider2D> ().size = new Vector2(110,110);
				Collection_5.GetComponent<Image> ().color = new Color32 (255, 255, 255, 255);
			}
		}
	}

	private void PurchaseManager_OnPurchaseNonConsumable (UnityEngine.Purchasing.PurchaseEventArgs args)
	{
		switch(args.purchasedProduct.definition.id.ToString())
		{
		case "collection_1":
			collection_1.GetComponent<SelectCollection> ().Shop = true;
			Panelcollection_1.SetActive (false);
			for (int i = 0; i < imag.Length; i++) 
			{
				imag[i].GetComponent<Image> ().color = new Color32 (255, 255, 255, 255);
				imag [i].GetComponent<BoxCollider2D> ().size = new Vector2(110,110);
				Collection_1.GetComponent<Image> ().color = new Color32 (255, 255, 255, 255);
			}
			break;
		
		case "collection_2":
			collection_2.GetComponent<SelectCollection>().Shop=true;
			Panelcollection_2.SetActive (false);
			for (int i = 0; i < imag.Length; i++) 
			{
				imag[i].GetComponent<Image> ().color = new Color32 (255, 255, 255, 255);
				imag [i].GetComponent<BoxCollider2D> ().size = new Vector2(110,110);
				Collection_2.GetComponent<Image> ().color = new Color32 (255, 255, 255, 255);
			}
			break;

		case "collection_3":
			collection_3.GetComponent<SelectCollection>().Shop=true;
			Panelcollection_3.SetActive (false);
			for (int i = 0; i < imag.Length; i++) 
			{
				imag[i].GetComponent<Image> ().color = new Color32 (255, 255, 255, 255);
				imag [i].GetComponent<BoxCollider2D> ().size = new Vector2(110,110);
				Collection_3.GetComponent<Image> ().color = new Color32 (255, 255, 255, 255);
			}
			break;

		case "collection_4":
			collection_4.GetComponent<SelectCollection>().Shop=true;
			Panelcollection_4.SetActive (false);
			for (int i = 0; i < imag.Length; i++) 
			{
				imag[i].GetComponent<Image> ().color = new Color32 (255, 255, 255, 255);
				imag [i].GetComponent<BoxCollider2D> ().size = new Vector2(110,110);
				Collection_4.GetComponent<Image> ().color = new Color32 (255, 255, 255, 255);
			}
			break;

		case "collection_5":
			collection_5.GetComponent<SelectCollection>().Shop=true;
			Panelcollection_5.SetActive (false);
			for (int i = 0; i < imag.Length; i++) 
			{
				imag[i].GetComponent<Image> ().color = new Color32 (255, 255, 255, 255);
				imag [i].GetComponent<BoxCollider2D> ().size = new Vector2(110,110);
				Collection_5.GetComponent<Image> ().color = new Color32 (255, 255, 255, 255);
			}
			break;
		}
	}


}
