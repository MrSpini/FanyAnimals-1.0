using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectCollInShop : MonoBehaviour {
	public Image Status;

	public Sprite Lock;
	public Sprite Activ;
	public Sprite NotActiv;
    public Image CheckAnimal;
    public Image[] AnimalsMenu = new Image[4];
	public bool Buy;

    bool switcher = true;
	void OnMouseDown()
	{
        if (Buy == true)
        {
            switch (switcher)
            {
                case true:
                    Status.GetComponent<Image>().sprite = Activ;
                    switcher = false;
                   // AnimalsMenu[0].sprite = CheckAnimal.sprite;
                    switch(CheckAnimal.sprite.name.ToString())
                    {   
                        case "Кит":
                            AnimalsMenu[3].sprite = CheckAnimal.sprite;
                            break;
                        case "Енот":
                            AnimalsMenu[2].sprite = CheckAnimal.sprite;
                            break;
                        case "Лев":
                            AnimalsMenu[1].sprite = CheckAnimal.sprite;
                            break;
                        case "Кошка":
                            AnimalsMenu[0].sprite = CheckAnimal.sprite;
                            break;
                    }
                    break;
                case false:
                    Status.GetComponent<Image>().sprite = NotActiv;
                    switcher = true;
                    
                    break;
            }
        }
	}

    void Start()
    {
        StartCoroutine(Check());
    }

    IEnumerator Check()
    {
        if (Buy == true)
        {
            Status.GetComponent<Image>().sprite = NotActiv;
            yield return new WaitForSeconds(0.1f);
        }
    }
}
