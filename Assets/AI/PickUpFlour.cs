using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpFlour : GAction
{
    public Inventory windMill;
    public override bool PrePerform()
    {

        beliefs.ModifyState("atWorking", 1);
        return true;
    }

    public override bool PostPerform()
    {
        this.GetComponent<Inventory>().flourLevel += 5;
        windMill.flourLevel-=5;
        GWorld.Instance.GetWorld().ModifyState("hasFlour", 1);
        GWorld.Instance.GetWorld().ModifyState("hasStock", -1);
        GWorld.Instance.GetWorld().ModifyState("hasntFlour", -1);
        GWorld.Instance.GetWorld().ModifyState("PickedUpFlour", 1);
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

