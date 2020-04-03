using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farmer : GAgent
{
    // Start is called before the first frame update
    new void Start()
    {
        base.Start();
        SubGoal s1 = new SubGoal("isFarming", 1, false);
        goals.Add(s1, 1);
        //SubGoal s2 = new SubGoal("hasProduct", 1, true);
        //goals.Add(s2, 3);
        SubGoal s3 = new SubGoal("AddToStocks", 1, false);
        goals.Add(s3, 3);
        //SubGoal s3 = new SubGoal("isSleeping", 1, true);
        //goals.Add(s3, 1);
    }

}
