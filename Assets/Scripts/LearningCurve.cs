using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public int currentAge = 4;
    private Transform camTransform;
    private Transform lightTransform;

    // Start is called before the first frame update
    void Start()
    {
        lightTransform = GameObject.Find("Directional Light").GetComponent<Transform>();
        Debug.Log(lightTransform.localPosition);

        camTransform = GetComponent<Transform>();
        Debug.Log(camTransform.localPosition);

        var hero = new Character();
        hero.PrintStatsInfo();

        var heroine = new Character("Agatha");
        heroine.PrintStatsInfo();

        var huntingBow = new Weapon("Hunting Bow", 105);
        var warBow = huntingBow;
        warBow.Name = "War Bow";
        warBow.Damage = 155;

        var knight = new Paladin("Sir Arthur", huntingBow);
        knight.PrintStatsInfo();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
