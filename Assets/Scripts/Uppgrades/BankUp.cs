using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BankUp : CPSUpgrades
{

    public override void Start()
    {
        base.Start();
    }

    public override void Update()
    {
        base.Update();
        if (level == 0)
        {
            cPSM.bankCPSBoost = 1;
        }
        else
        {
            cPSM.bankCPSBoost = 1 + (incPerLevel * level);
        }

    }
}
