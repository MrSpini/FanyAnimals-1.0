using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopTime : MonoBehaviour
{
    public GameObject ShopPanel, GamePanel;
    public Text Times;
	void Start () 
    {
        if(ShopPanel.activeInHierarchy == true)
        StartCoroutine(Time());
	}
	
    IEnumerator Time()
    {
        for (int i = 10; i > 0; i--)
        {   
           // Times.text = i.ToString();

            yield return new WaitForSeconds(1);
            if (i == 1)
            {
                ShopPanel.SetActive(false);
                GamePanel.SetActive(true);
            }
        }
    }
	
}
