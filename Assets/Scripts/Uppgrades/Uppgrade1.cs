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

    public int level;
    float upCost;
    int upCostRound;

    // Start is called before the first frame update
    void Start()
    {
        CC = Manager.GetComponent<ClickableCoin>();
        upCost = 20;
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
    }

    public void onButtonPress()
    {
        if (CC.CoinCounter >= upCostRound)
        {
            level++;
            CC.CoinCounter -= upCostRound;
            upCost *= 1.3f;
        }
    }
}
