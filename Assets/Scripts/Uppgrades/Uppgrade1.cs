using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Uppgrade1 : MonoBehaviour
{
    [SerializeField]
    TMP_Text uppgradeLevel;

    [SerializeField]
    GameObject Manager;

    ClickableCoin CC;

    int level;
    float upCost;

    // Start is called before the first frame update
    void Start()
    {
        CC = Manager.GetComponent<ClickableCoin>();
        upCost = 25;
    }

    // Update is called once per frame
    void Update()
    {
        uppgradeLevel.text = level.ToString();
    }

    public void onButtonPress()
    {
        if (CC.CoinCounter >= upCost)
        {
            level++;
            CC.CoinCounter -= upCost;
            upCost *= 1.5f;
        }
    }
}
