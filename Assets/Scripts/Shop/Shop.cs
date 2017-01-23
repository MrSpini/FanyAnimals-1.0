using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour 
{
    public GameObject Shoper, Game;
    public Image[] Items,Animal = new Image[5]; 
    public Sprite[] sprites = new Sprite[2];
    public bool[] shopsss = new bool[5];
    bool panel = true;
	void Start () 
    {
        StartCoroutine(ShopItems());	
	}
	
    void OnMouseDown()
    {
        switch(panel)
        {
            case true:
                Shoper.SetActive(true);
                Game.SetActive(false);
                panel = false;
                break;
            case false:
                Shoper.SetActive(false);
                Game.SetActive(true);
                panel = true;
                break;
        }
    }

    IEnumerator ShopItems()
    {  
        for (int i = 0; i < shopsss.Length; i++)
        {
            if (shopsss[i] == true)
                Items[i].sprite = sprites[0];
            else
            {
                Items[i].sprite = sprites[1];
                Animal[i].color = new Color32(255,255,255,180);
            }
        }
        yield return new WaitForSeconds(0.1f);
    }
}
