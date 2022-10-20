using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Harvest : GAction
{
    public override bool PrePerform()
    {

        return true;
    }

    public override bool PostPerform()
    {
        Debug.Log("Harvest Post Perform");
        GWorld.Instance.GetWorld().ModifyState("hasWheat", 1);
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
