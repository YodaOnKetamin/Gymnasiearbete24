using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUP : CPSUpgrades
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
            CC.cilckerUp = 1;
        }
        else
        {
            CC.cilckerUp = 1 + (incPerLevel * level);
        }
    }
}
