using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class AutoGen : MonoBehaviour
{
    [SerializeField]
    string UpradeName;
    [SerializeField]
    TMP_Text uppgradeLevel;

    [SerializeField]
    TMP_Text cost;

    [SerializeField]
    GameObject Manager;

    [SerializeField]
    Button button;

    ClickableCoin CC;

    public int level;
   
    int upCostRound;
   
    public float perSecGen;

    //change in arv
    [SerializeField]
    public float upCost;
    [SerializeField]
    public float BaseCost;
    [SerializeField]
    public float incCost;
    public float incPerLevel;

    BuySellManager BSM;
    
    

    // Start is called before the first frame update
    public virtual void Start()
    {
        CC = Manager.GetComponent<ClickableCoin>();
        BSM = Manager.GetComponent<BuySellManager>();
        upCost = BaseCost * Mathf.Pow(incCost, level);
    }

    // Update is called once per frame
    public virtual void Update()
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
        perSecGen = incPerLevel * level;

       
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
            BSM.sellamount = 0.8f *(BaseCost* (Mathf.Pow(incCost,level-1)));
            CC.CoinCounter += BSM.sellamount;
            BSM.sellamount = 0;
            level--;
            upCost = BaseCost * Mathf.Pow(incCost, level);
        }
       
    }
}
