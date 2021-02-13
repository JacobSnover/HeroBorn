using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public int currentAge = 4;
    // Start is called before the first frame update
    void Start()
    {
        //ComputeAge();

        var hero = new Character();
        hero.PrintStatsInfo();

        var heroine = new Character("Agatha");
        heroine.PrintStatsInfo();
    }

    //void ComputeAge()
    //{
    //    Debug.Log(1 + 3);

    //    Debug.Log($"{currentAge + 4}");
    //}

    // Update is called once per frame
    void Update()
    {

    }
}
