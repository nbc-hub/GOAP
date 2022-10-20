using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToBakery : GAction
{

    public override bool PrePerform()
    {

        beliefs.ModifyState("atWorking", 1);
        return true;
    }

    public override bool PostPerform()
    {
        if (this.GetComponent<Inventory>().flourLevel == 0)
        {
            GWorld.Instance.GetWorld().ModifyState("hasFlour", -1);
            GWorld.Instance.GetWorld().ModifyState("hasntFlour", 1);
         
        }
        Debug.Log(this.GetComponent<Inventory>().breadLevel);
        if(this.GetComponent<Inventory>().breadLevel >= 5){
            Debug.Log(this.GetComponent<Inventory>().breadLevel);
          
            GWorld.Instance.GetWorld().ModifyState("hasDelivary", 1);
        }
        GWorld.Instance.GetWorld().ModifyState("Bake", 1);
        beliefs.ModifyState("atWorking", -1);
        return true;

    }

    IEnumerator iEPerform()
    {
        if (this.GetComponent<Inventory>().flourLevel >= 2)
        {
            this.GetComponent<Inventory>().flourLevel -= 2;
            this.GetComponent<Inventory>().breadLevel += 1;
            yield return new WaitForSeconds(1f);
            if (this.GetComponent<Inventory>().flourLevel >= 2)
            {
                this.GetComponent<Inventory>().flourLevel -= 2;
                this.GetComponent<Inventory>().breadLevel += 1;
                yield return new WaitForSeconds(1f);

                if (this.GetComponent<Inventory>().flourLevel >= 2)
                {
                    this.GetComponent<Inventory>().flourLevel -= 2;
                    this.GetComponent<Inventory>().breadLevel += 1;
                    yield return new WaitForSeconds(1f);
                }
                else
                {
                    GWorld.Instance.GetWorld().ModifyState("hasFlour", -1);
                    GWorld.Instance.GetWorld().ModifyState("hasntFlour", 1);
                    yield return null;
                }
            }
            else
            {

                GWorld.Instance.GetWorld().ModifyState("hasFlour", -1);
                GWorld.Instance.GetWorld().ModifyState("hasntFlour", 1);
                yield return null;
            }
        }
        else
        {

            GWorld.Instance.GetWorld().ModifyState("hasFlour", -1);
            GWorld.Instance.GetWorld().ModifyState("hasntFlour", 1);
            yield return null;
        }

    }

    public override void Perform()
    {
        StartCoroutine(iEPerform());
        Debug.Log(this.GetComponent<Inventory>().breadLevel);
    }

}

