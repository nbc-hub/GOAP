using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToDelivary : GAction
{
public override bool PrePerform()
    {

        beliefs.ModifyState("atWorking", 1);
        return true;
    }

    public override bool PostPerform()
    {
        this.GetComponent<Inventory>().breadLevel -= 5;
        this.GetComponent<Inventory>().delivaryLevel += 1;
        GWorld.Instance.GetWorld().ModifyState("hasDelivary", -1);
        GWorld.Instance.GetWorld().ModifyState("doJob", 1);
        beliefs.ModifyState("atWorking", -1);
        return true;

    }

    IEnumerator iEPerform()
    {
      yield return null;
    }

    public override void Perform()
    {
        StartCoroutine(iEPerform());
    }


}

