using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CPSManager : MonoBehaviour
{
    float totalCPS;
    float timer;

    Factory Factory;
    Mine Mine;
    Minion Minion;
    [SerializeField]
    GameObject upgradeManager;

    [SerializeField]
    TMP_Text CPScounter;

    ClickableCoin CC;

    public float minionCPSBoost;
    public float mineCPSBoost;
    public float factoryCPSBoost;
    public float totalCPSBoost;


    // Start is called before the first frame update
    public virtual void Start()
    {
        Factory = upgradeManager.GetComponent<Factory>();
        Mine = upgradeManager.GetComponent<Mine>();
        Minion = upgradeManager.GetComponent<Minion>();
        CC = gameObject.GetComponent<ClickableCoin>();
        totalCPSBoost = 1;
        minionCPSBoost = 1;
        mineCPSBoost = 1;
        factoryCPSBoost = 1;
    }

    // Update is called once per frame
    public virtual void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 0.1f)
        {
            CC.CoinCounter += (totalCPS / 10);
            timer = 0;
        }

        CPScounter.text = "CPS: " + totalCPS.ToString();

        totalCPS = totalCPSBoost * ((Minion.perSecGen * minionCPSBoost) + (Mine.perSecGen * mineCPSBoost) + (Factory.perSecGen * factoryCPSBoost));
    }
}
