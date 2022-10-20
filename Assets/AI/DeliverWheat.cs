using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliverWheat : GAction
{
    public Inventory windMill;
    public override bool PrePerform()
    {

        beliefs.ModifyState("atWorking", 1);
        return true;
    }

    public override bool PostPerform()
    {
        Debug.Log("DeliverWheat Post Perform");
        if(windMill.flourLevel >=5){
            GWorld.Instance.GetWorld().ModifyState("hasStock", 1);
        }
        GWorld.Instance.GetWorld().ModifyState("hasWheat", -1);
        return true;

    }

    IEnumerator iEPerform()
    {
        windMill.flourLevel++;
        yield return new WaitForSeconds(1f);
        windMill.flourLevel++;
        yield return new WaitForSeconds(1f);
        windMill.flourLevel++;
        yield return new WaitForSeconds(1f);

    }

    public override void Perform()
    {
        StartCoroutine(iEPerform());
    }
}
