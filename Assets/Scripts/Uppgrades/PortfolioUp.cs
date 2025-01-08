using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortfolioUp : CPSUpgrades
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
            cPSM.portfolioCPSBoost = 1;
        }
        else
        {
            cPSM.portfolioCPSBoost = 1 + (incPerLevel * level);
        }

    }
}
