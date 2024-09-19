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
    public float incCost;
    public float incPerLevel;

    

    // Start is called before the first frame update
    public virtual void Start()
    {
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
        uppgradeLevel.text = level.ToString();
        cost.text = upCostRound.ToString();
        perSecGen = incPerLevel * level;
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
