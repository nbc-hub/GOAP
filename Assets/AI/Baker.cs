using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baker : GAgent {

    protected override void Start() {

        base.Start();
        SubGoal s1 = new SubGoal("GoToBakery", 1, false);
        goals.Add(s1, 5);

        SubGoal s3 = new SubGoal("doJob", 1, false);
        goals.Add(s3, 8);
        SubGoal s2 = new SubGoal("hasFlour", 1, false);
        goals.Add(s2, 3);
    }
}
