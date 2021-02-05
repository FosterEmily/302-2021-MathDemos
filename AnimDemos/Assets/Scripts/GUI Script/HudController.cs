using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HudController : MonoBehaviour
{

    public static float timeScale = .5f;
    public static float currenTime;

    public TMP_Text testTimeScale;
    public Slider sliderLerp;
    public LerpDemo lerper;

    void Start()
    {

        SlinderTimeUpdated(1);

    }


    void Update()
    {
   
       float p = lerper.getCurrentPercent;
        sliderLerp.SetValueWithoutNotify(p);

    }

    public void SlinderTimeUpdated(float amt)
    {

        timeScale = amt;

        testTimeScale.text = System.Math.Round(timeScale, 2).ToString();

    }

    public void SliderLerpUpdated(float amt)
    {

        lerper.DoTheLerp(amt);

    }
}
