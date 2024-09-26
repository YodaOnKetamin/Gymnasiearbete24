using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Uppgrade1 : MonoBehaviour
{
    [SerializeField]
    TMP_Text uppgradeLevel;

    [SerializeField]
    TMP_Text cost;

    [SerializeField]
    GameObject Manager;

    [SerializeField]
    Button button;

    ClickableCoin CC;
    BuySellManager BSM;

    public int level;
    float upCost;
    float BaseCost;
    int upCostRound;
    float incCost;

    // Start is called before the first frame update
    void Start()
    {
        CC = Manager.GetComponent<ClickableCoin>();
        BSM = Manager.GetComponent<BuySellManager>();
        upCost = 20;
        BaseCost = 20;
        incCost = 1.3f;
    }

    // Update is called once per frame
    void Update()
    {
        if (BSM.buy == true)
        {
            if (CC.CoinCounter < upCostRound)
            {
                button.interactable = false;
            }
            else
            {
                button.interactable = true;
            }
        }
        else
        {
            if (level == 0)
            {
                button.interactable = false;
            }
            else
            {
                button.interactable = true;
            }
        }
        upCostRound = (int)(upCost + 0.5f);
        uppgradeLevel.text = level.ToString();
        cost.text = upCostRound.ToString();
    }

    public void onButtonPress()
    {
        if (BSM.buy == true)
        {
            if (CC.CoinCounter >= upCostRound)
            {
                level++;
                CC.CoinCounter -= upCostRound;
                upCost = BaseCost * Mathf.Pow(incCost, level);
            }
        }
        else
        {
            BSM.sellamount = 0.8f * (BaseCost * (Mathf.Pow(incCost, level - 1)));
            CC.CoinCounter += BSM.sellamount;
            BSM.sellamount = 0;
            level--;
            upCost = BaseCost * Mathf.Pow(incCost, level);
        }
    }
}
