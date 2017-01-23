using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectCollection : MonoBehaviour {

	public GameObject GamePanel;
	public GameObject ShopPanel;
	public GameObject MenuPanel;
	public GameObject LockPanel,LockPanel_0,LockPanel_1,LockPanel_2,LockPanel_3,LockPanel_4;
	public GameObject Cap;

	public Image Status;

	public Sprite Lock;
	public Sprite Activ;

	public GameObject[] imag=new GameObject[12];

	public Sprite[] im = new Sprite[12];
	public GameObject Collection;

	public bool Shop;

	void OnMouseDown()
	{
		for (int i = 0; i < imag.Length; i++) {
			imag[i].GetComponent<Image> ().sprite = im[i];

			if (Shop == true) 
			{
				GamePanel.SetActive (true);
				MenuPanel.SetActive (true);
				ShopPanel.SetActive (false);
				LockPanel_0.SetActive (false);
				LockPanel_1.SetActive (false);
				LockPanel_2.SetActive (false);
				LockPanel_3.SetActive (false);
				LockPanel_4.SetActive (false);

				imag[i].GetComponent<Image> ().color = new Color32 (255, 255, 255, 255);
				imag [i].GetComponent<BoxCollider2D> ().size = new Vector2(110,110);
				Collection.GetComponent<Image> ().color = new Color32 (255, 255, 255, 255);
			}
			 else 
			{
				ShopPanel.SetActive (false);
				Cap.SetActive (true);
				LockPanel.SetActive (true);
				MenuPanel.SetActive (false);
				Cap.GetComponent<KeyChange> ().Start ();
				imag[i].GetComponent<Image> ().color = new Color32 (255, 255, 255, 100);
				imag [i].GetComponent<BoxCollider2D> ().size = new Vector2(0,0);
				Collection.GetComponent<Image> ().color = new Color32 (255, 255, 255, 100);

			}
		}
	}

	private void Update()
	{
		if (Shop == true)
		{
			Status.GetComponent<Image>().sprite = Activ;
			Collection.GetComponent<Image> ().color = new Color32 (255, 255, 255, 255);
		}
    }
}
