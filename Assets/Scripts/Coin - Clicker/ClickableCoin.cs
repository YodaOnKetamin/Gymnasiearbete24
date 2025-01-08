using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Globalization;

public class ClickableCoin : MonoBehaviour
{
    [SerializeField]
    TMP_Text CoinCounterText;

    Uppgrade1 upgrade1;

    [SerializeField]
    GameObject Upmanager;

   public float CoinCounter;

    int coinCouterRound;

    float clickerMulti;
    public float cilckerUp;

    // Start is called before the first frame update
    void Start()
    {
        upgrade1 = Upmanager.GetComponent<Uppgrade1>();
    }

    // Update is called once per frame
    void Update()
    {
        coinCouterRound = (int)(CoinCounter + 0.5f);

            CoinCounterText.text = coinCouterRound.ToString();
        
        
        
        clickerMulti = (upgrade1.level+1);
    }

    public void onButtonPress() 
    {
        CoinCounter += (clickerMulti);
    }
}
