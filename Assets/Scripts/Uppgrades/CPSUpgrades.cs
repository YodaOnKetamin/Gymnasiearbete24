using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CPSUpgrades : MonoBehaviour
{
    [SerializeField]
    GameObject Manager;
   public  CPSManager cPSM;
   public ClickableCoin CC;

    [SerializeField]
    TMP_Text cost;
    [SerializeField]
    TMP_Text uppgradeLevel;
    [SerializeField]
    Button button;

    public int level;
    [SerializeField]
    public float upCost;
    [SerializeField]
    public float incCost;
    public float incPerLevel;
    int upCostRound;

    // Start is called before the first frame update
    public virtual void Start()
    {
        cPSM = Manager.GetComponent<CPSManager>();
        CC = Manager.GetComponent<ClickableCoin>();
    }

    // Update is called once per frame
    public virtual void Update()
    {
        if (CC.CoinCounter < upCostRound)
        {
            button.interactable = false;
        }
        else
        {
            button.interactable = true;
        }
        upCostRound = (int)(upCost + 0.5f);
        uppgradeLevel.text = "lvl: "+level.ToString();
        cost.text = upCostRound.ToString();
    }

    public void onButtonPress()
    {
        if (CC.CoinCounter >= upCostRound)
        {
            level++;
            CC.CoinCounter -= upCostRound;
            upCost *= incCost;
        }
    }
}
