/////////////////////////
//// Name: Sim McQueen
//// Date: 10/21/2020
//// Desc: Makes a sprite flash colors like a mariokart star
/////////////////////////





using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RGBSprite : MonoBehaviour
{
    [Tooltip("How long it will take to shift from one color to the next")]
    public float ColorShiftTime = 1;
    SpriteRenderer mySR;
    // Start is called before the first frame update
    void Start()
    {
        mySR = GetComponent<SpriteRenderer>();
        StartCoroutine(TurnRed());

    }

    IEnumerator TurnRed()
    {

        float timer = 0;
        Color OrginalColor = mySR.color;
        while(timer <= ColorShiftTime)
        {
            yield return null;
            timer += Time.deltaTime;
            mySR.color = Color.Lerp(OrginalColor, new Color(1, 0, 0, 1), timer/ColorShiftTime);
        }

        StartCoroutine(TurnYellow());

    }
    IEnumerator TurnYellow()
    {

        float timer = 0;
        Color OrginalColor = mySR.color;
        while (timer <= ColorShiftTime)
        {
            yield return null;
            timer += Time.deltaTime;
            mySR.color = Color.Lerp(OrginalColor, new Color(1, 1, 0, 1), timer / ColorShiftTime);
        }


        StartCoroutine(TurnGreen());
    }

    IEnumerator TurnGreen()
    {

        float timer = 0;
        Color OrginalColor = mySR.color;
        while (timer <= ColorShiftTime)
        {
            yield return null;
            timer += Time.deltaTime;
            mySR.color = Color.Lerp(OrginalColor, new Color(0, 1, 0, 1), timer / ColorShiftTime);
        }


        StartCoroutine(TurnCyan());
    }

    IEnumerator TurnCyan()
    {

        float timer = 0;
        Color OrginalColor = mySR.color;
        while (timer <= ColorShiftTime)
        {
            yield return null;
            timer += Time.deltaTime;
            mySR.color = Color.Lerp(OrginalColor, new Color(0, 1, 1, 1), timer / ColorShiftTime);
        }


        StartCoroutine(TurnBlue());
    }

    IEnumerator TurnBlue()
    {

        float timer = 0;
        Color OrginalColor = mySR.color;
        while (timer <= ColorShiftTime)
        {
            yield return null;
            timer += Time.deltaTime;
            mySR.color = Color.Lerp(OrginalColor, new Color(0, 0, 1, 1), timer / ColorShiftTime);
        }


        StartCoroutine(TurnMagenta());
    }

    IEnumerator TurnMagenta()
    {

        float timer = 0;
        Color OrginalColor = mySR.color;
        while (timer <= ColorShiftTime)
        {
            yield return null;
            timer += Time.deltaTime;
            mySR.color = Color.Lerp(OrginalColor, new Color(1, 0, 1, 1), timer / ColorShiftTime);
        }


        StartCoroutine(TurnRed());
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
