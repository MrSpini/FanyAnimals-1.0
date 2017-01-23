using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyChange : MonoBehaviour
{
    int index = 0;
    public Image[] Capcha = new Image[9];
    public Sprite[] CapchasAnimals = new Sprite[9];
	public GameObject Cap,ShopPanel,Games,MenuPanel;
    public Text Times;
    bool[] truth = new bool[9];

	int check;

	public void Start()
    {
            RandomAnimals();   
			StartCoroutine (Time ());
		for (int i = 0; i < truth.Length; i++) 
		{
			truth [i] = false;
		}
	}

	void Proverka()
	{
		check=0;
		for (int i = 0; i < truth.Length; i++) 
		{
			if (truth [i] == true)
				check++;

			if (check == index) 
			{
				Cap.SetActive (false);
				ShopPanel.SetActive (false);
				MenuPanel.SetActive (true);
				Games.SetActive (true);
			}
		}
	}

    public void AnimalsImage_0()
    {
		if (Capcha [0].sprite.name == "Кошка")
		{
			truth [0] = true;
		}
        else
        {
            Cap.SetActive(false);
            ShopPanel.SetActive(true);

		}
		Proverka ();
    }
    public void AnimalsImage_1()
    {
		if (Capcha [1].sprite.name == "Кошка")
		{
			truth [1] = true;
		}
        else
        {
            Cap.SetActive(false);
            ShopPanel.SetActive(true);
		}
		Proverka ();
    }
    public void AnimalsImage_2()
    {
		
		if (Capcha [2].sprite.name == "Кошка")
		{
			truth [2] = true;
		}
        else
        {
            Cap.SetActive(false);
            ShopPanel.SetActive(true);
		}
		Proverka ();
    }

    public void AnimalsImage_3()
    {
		
		if (Capcha [3].sprite.name == "Кошка")
		{
			truth [3] = true;
		}
        else
        {
            Cap.SetActive(false);
            ShopPanel.SetActive(true);
		}
		Proverka ();
    }

    public void AnimalsImage_4()
    {
		
		if (Capcha [4].sprite.name == "Кошка") 
		{
			truth [4] = true;
		}
        else
        {
            Cap.SetActive(false);
            ShopPanel.SetActive(true);
		}
		Proverka ();
    }

    public void AnimalsImage_5()
    {
		
		if (Capcha [5].sprite.name == "Кошка")
		{
			truth [5] = true;
		}
        else
        {
            Cap.SetActive(false);
            ShopPanel.SetActive(true);
		}
		Proverka ();
    }

    public void AnimalsImage_6()
    {
		
		if (Capcha [6].sprite.name == "Кошка")
		{
			truth [6] = true;
		}
        else
        {
            Cap.SetActive(false);
            ShopPanel.SetActive(true);
		}
		Proverka ();
    }

    public void AnimalsImage_7()
    {
		
		if (Capcha [7].sprite.name == "Кошка") 
		{
			truth [7] = true;
		}
        else
        {
			
            Cap.SetActive(false);
            ShopPanel.SetActive(true);
		}
		Proverka ();
    }

    public void AnimalsImage_8()
    {
		if (Capcha [8].sprite.name == "Кошка")
		{
			truth [8] = true;
		}
        else
        {
            Cap.SetActive(false);
            ShopPanel.SetActive(true);
		}
		Proverka ();

    }

	void RandomAnimals()
    {
		index = 0;
        for (int i = 0; i < Capcha.Length; i++)
        {
            Capcha[i].sprite = CapchasAnimals[Random.Range(0, 9)];
			if (Capcha [i].sprite.name == "Кошка") {
				index++;
			}
        }
    }

    IEnumerator Time()
    {   
		for (int j = 10; j > -1; j--)
		{   
			Times.text = j.ToString();
			yield return new WaitForSeconds(1);
			if (j == 0)
			{ 
				j = 10;
				ShopPanel.SetActive(true);
				Cap.SetActive(false);
			}
		}
		yield return new WaitForSeconds (0.01f);
    }   
}
