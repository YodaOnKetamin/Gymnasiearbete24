using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClickableCoin : MonoBehaviour
{
    [SerializeField]
    TMP_Text CoinCounterText;
    

   public float CoinCounter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CoinCounterText.text = CoinCounter.ToString();
    }

    public void onButtonPress() 
    {
        CoinCounter++;
    }
}
