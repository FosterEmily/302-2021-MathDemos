using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpDemo : MonoBehaviour
{
    public GameObject objectStart;
    public GameObject objectEnd;

   [Range(-2,2)] public float percent = 0;

    public float animationLength = 2;
    private float animationPlayheadTime = 0;
    private bool isAnimationPlaying = false;

    public AnimationCurve animationCurve;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(isAnimationPlaying)
        {
            //move playhead forward
            animationPlayheadTime += Time.deltaTime;
            //calc new value for percent
            percent = animationPlayheadTime / animationLength;
            //clamp in 0 to 1 range
            percent = Mathf.Clamp(percent, 0, 1);

            float p = animationCurve.Evaluate(percent);
      
            //move object to lerped position:
            DoTheLerp(p);
            //playing
            if (percent >= 1) isAnimationPlaying = false;
        }

        transform.position = AnimMath.Lerp(objectStart.transform.position, objectEnd.transform.position, percent);

    }

    public void DoTheLerp(float p)
    {

        transform.position = AnimMath.Lerp(
            objectStart.transform.position,
            objectEnd.transform.position,
            p
            );
    }
    public void PlayTweenAnim()
    {

        isAnimationPlaying = true;
        animationPlayheadTime = 0;
    
    }
    private void onValidate()
    {
        transform.position = AnimMath.Lerp(objectStart.transform.position, objectEnd.transform.position, percent);
    }
}
