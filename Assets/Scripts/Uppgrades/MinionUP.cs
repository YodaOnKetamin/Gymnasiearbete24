using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionUP : CPSUpgrades
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
            cPSM.minionCPSBoost = 1;
        }
        else
        {
            cPSM.minionCPSBoost = 1 + (incPerLevel * level);
        }
    
}
}
