using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClickableCoin : MonoBehaviour
{
    [SerializeField]
    TMP_Text CoinCounterText;

    Uppgrade1 upgrade1;

    [SerializeField]
    GameObject Upmanager;

   public float CoinCounter;

    float clickerMulti;

    // Start is called before the first frame update
    void Start()
    {
        upgrade1 = Upmanager.GetComponent<Uppgrade1>();
    }

    // Update is called once per frame
    void Update()
    {
        CoinCounterText.text = CoinCounter.ToString();
        clickerMulti = (upgrade1.level+1);
    }

    public void onButtonPress() 
    {
        CoinCounter += (1 * clickerMulti);
    }
}
