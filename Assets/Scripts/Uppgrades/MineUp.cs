using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineUp : CPSUpgrades
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
            cPSM.mineCPSBoost = 1;
        }
        else
        {
            cPSM.mineCPSBoost = 1 + (incPerLevel * level);
        }

    }
}
