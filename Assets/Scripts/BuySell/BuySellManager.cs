using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuySellManager : MonoBehaviour
{
   public bool sell;
    public bool buy;

    [SerializeField]
    Button BuyButton;
    [SerializeField]
    Button SellButton;

   public float sellamount;

    // Start is called before the first frame update
    void Start()
    {
        buy = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (buy == true)
        {
            BuyButton.GetComponent<Image>().color = Color.green;
        }
        else
        {
            BuyButton.GetComponent<Image>().color = Color.white;
        }

        if (sell == true)
        {
            SellButton.GetComponent<Image>().color = Color.green;
        }
        else
        {
            SellButton.GetComponent<Image>().color = Color.white;
        }
    }

    public void OnBuyButtonPress() 
    {
        buy = true;
        sell = false;
    }

    public void OnSellButtonPress()
    {
        sell = true;
        buy = false;
    }
}
