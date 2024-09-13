using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class AutoGen : MonoBehaviour
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

    public int level;
   
    int upCostRound;
    float timer;
    float perSecGen;

    //change in arv
    [SerializeField]
    public float upCost;
    [SerializeField]
    public float incCost;
    public float incPerLevel;

    // Start is called before the first frame update
    void Start()
    {
        CC = Manager.GetComponent<ClickableCoin>();
    }

    // Update is called once per frame
   void Update()
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

        timer += Time.deltaTime;

        if (timer >= 0.1f)
        {
            CC.CoinCounter += (perSecGen / 10);
            timer = 0;
        }

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
