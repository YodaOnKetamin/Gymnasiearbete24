using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryUp : CPSUpgrades
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
            cPSM.factoryCPSBoost = 1;
        }
        else
        {
            cPSM.factoryCPSBoost = 1 + (incPerLevel * level);
        }

    }
}
