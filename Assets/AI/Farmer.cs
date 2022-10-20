using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farmer : GAgent {

    protected override void Start() {

        base.Start();
        SubGoal s1 = new SubGoal("doFarming", 1, false);
        goals.Add(s1, 4);

        
    }
}
