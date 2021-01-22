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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(isAnimationPlaying)
        {
            animationPlayheadTime += Time.deltaTime;

            percent = animationPlayheadTime / animationLength;
            percent = Mathf.Clamp(percent, 0, 1);
            DoTheLerp();
            if (percent >= 1) isAnimationPlaying = false;

            percent = percent * percent * (3 - 2 * percent);
        }

        transform.position = AnimMath.Lerp(objectStart.transform.position, objectEnd.transform.position, percent);

    }

    public void DoTheLerp()
    {

        transform.position = AnimMath.Lerp(
            objectStart.transform.position,
            objectEnd.transform.position,
            percent
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
