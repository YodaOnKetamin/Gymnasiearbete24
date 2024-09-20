using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPSUpgrade : CPSUpgrades
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
            cPSM.totalCPSBoost = 1;
        }
        else
        {
            cPSM.totalCPSBoost = 1 + (incPerLevel * level);
        }
       
    }
}
