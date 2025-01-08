using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saver : MonoBehaviour
{
    ClickableCoin CC;
    Uppgrade1 pick;
    Minion minion;
    Mine mine;
    Factory factory;
    Bank bank;
    Portfolio portfolio;
    CPSUpgrade cpsUp;
    MinionUP minionUp;
    MineUp mineUp;
    FactoryUp factoryUp;
    BankUp bankUp;
    PortfolioUp portfolioUp;

    [SerializeField]
    GameObject manager;
    [SerializeField]
    GameObject ups;
    [SerializeField]
    GameObject buildings;

    GameObject Dont;

    MenuAndSaveManager Menumanager;
    // Start is called before the first frame update
    void Start()
    {
        CC = manager.GetComponent<ClickableCoin>();
        pick = buildings.GetComponent<Uppgrade1>();
        minion = buildings.GetComponent<Minion>();
        mine = buildings.GetComponent<Mine>();
        factory = buildings.GetComponent<Factory>();
        bank = buildings.GetComponent<Bank>();
        portfolio = buildings.GetComponent<Portfolio>();
        cpsUp = ups.GetComponent<CPSUpgrade>();
        minionUp = ups.GetComponent<MinionUP>();
        mineUp = ups.GetComponent<MineUp>();
        factoryUp = ups.GetComponent<FactoryUp>();
        bankUp = ups.GetComponent<BankUp>();
        portfolioUp = ups.GetComponent<PortfolioUp>();
        Dont = GameObject.FindGameObjectWithTag("Dont");
       Menumanager = Dont.GetComponent<MenuAndSaveManager>();
        
        if (Menumanager.useSaved == true)
        {
            //load saved values
           CC.CoinCounter = PlayerPrefs.GetFloat("Cobble");
           pick.level = PlayerPrefs.GetInt("pickLvl");
           minion.level = PlayerPrefs.GetInt("minionLvl");
           mine.level = PlayerPrefs.GetInt("mineLvl");
           factory.level = PlayerPrefs.GetInt("factoryLvl");
           bank.level = PlayerPrefs.GetInt("bankLvl");
           portfolio.level = PlayerPrefs.GetInt("portfolioLvl");
           cpsUp.level = PlayerPrefs.GetInt("cpsUp");
           minionUp.level = PlayerPrefs.GetInt("minionUp");
           mineUp.level = PlayerPrefs.GetInt("mineUp");
           factoryUp.level = PlayerPrefs.GetInt("factoryUp");
           bankUp.level = PlayerPrefs.GetInt("bankUp");
           portfolioUp.level = PlayerPrefs.GetInt("portfolioUp");

            pick.upCost = PlayerPrefs.GetFloat("pickCost");
            minion.upCost = PlayerPrefs.GetFloat("minionCost");
            mine.upCost = PlayerPrefs.GetFloat("mineCost");
            factory.upCost = PlayerPrefs.GetFloat("factoryCost");
            bank.upCost = PlayerPrefs.GetFloat("bankCost");
            portfolio.upCost = PlayerPrefs.GetFloat("portfolioCost");
            cpsUp.upCost = PlayerPrefs.GetFloat("cpsUpCost");
            minionUp.upCost = PlayerPrefs.GetFloat("minionUpCost");
            mineUp.upCost = PlayerPrefs.GetFloat("mineUpCost");
            factoryUp.upCost = PlayerPrefs.GetFloat("factoryUpCost");
            bankUp.upCost = PlayerPrefs.GetFloat("bankUpCost");
            portfolioUp.upCost = PlayerPrefs.GetFloat("portfolioUpCost");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void SaveButton() 
    {
        PlayerPrefs.SetFloat("Cobble", CC.CoinCounter);
        PlayerPrefs.SetInt("pickLvl",pick.level);
        PlayerPrefs.SetInt("minionLvl",minion.level);
        PlayerPrefs.SetInt("mineLvl",mine.level);
        PlayerPrefs.SetInt("factoryLvl",factory.level);
        PlayerPrefs.SetInt("bankLvl",bank.level);
        PlayerPrefs.SetInt("portfolioLvl",portfolio.level);
        PlayerPrefs.SetInt("cpsUp",cpsUp.level);
        PlayerPrefs.SetInt("minionUp",mineUp.level);
        PlayerPrefs.SetInt("mineUp",mineUp.level);
        PlayerPrefs.SetInt("factoryUp",factoryUp.level);
        PlayerPrefs.SetInt("bankUp",bankUp.level);
        PlayerPrefs.SetInt("portfolioUp",portfolioUp.level);

        PlayerPrefs.SetFloat("pickCost", pick.upCost);
        PlayerPrefs.SetFloat("minionCost", minion.upCost);
        PlayerPrefs.SetFloat("mineCost", mine.upCost);
        PlayerPrefs.SetFloat("factoryCost", factory.upCost);
        PlayerPrefs.SetFloat("bankCost", bank.upCost);
        PlayerPrefs.SetFloat("portfolioCost", portfolio.upCost);
        PlayerPrefs.SetFloat("cpsUpCost", cpsUp.upCost);
        PlayerPrefs.SetFloat("minionUpCost", minionUp.upCost);
        PlayerPrefs.SetFloat("mineUpCost", mineUp.upCost);
        PlayerPrefs.SetFloat("factoryUpCost", factoryUp.upCost);
        PlayerPrefs.SetFloat("bankUpCost", bankUp.upCost);
        PlayerPrefs.SetFloat("portfolioUpCost", portfolioUp.upCost);
        Application.Quit();
        print("Quit");
    }
}
