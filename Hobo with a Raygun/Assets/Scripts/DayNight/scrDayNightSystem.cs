using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scrDayNightSystem : MonoBehaviour
{
    public float time = 1f;
    public float day = 1f;
    public float daySpeed = 60f;
    public float transitionSpeed = 4f;
    public float intensity;
    public float fullIntensity = 0.5f;
    public float fullScale = 1f;
    public SpriteRenderer sr;

    public bool isDay()
    {
        if (day == 1)
            return true;
        else
            return false;
    }

    public void FixedUpdate()
    {
        TimeUpdate();
    }

    public void TimeUpdate()
    {
        switch (day)
        {
            case 1f: //Day
                time = shrink(time, daySpeed);

                if (time == 0f)
                {
                    time = 1f;
                    day = 1.5f;
                }
                break;

            case 1.5f: //Night Transition
                {
                    intensity = grow(intensity, transitionSpeed);

                    if (intensity == 1f)
                        day = 0f;
                }
                break;
            case 0: //Night
                time = shrink(time, daySpeed);

                if (time == 0f)
                {
                    time = 1f;
                    day = 0.5f;
                }
                break;
            case 0.5f: //Day Transition
                {
                    intensity = shrink(intensity, transitionSpeed);

                    if (intensity == 0f)
                        day = 1f;
                }
                break;
        }
        sr.color = new Color(1f, 1f, 1f, intensity * fullIntensity * (float)Math.Pow((float)intensity,2));
    }

    float shrink(float status, float seconds)
    {
        if (status > 0f)
        {
            status -= Time.deltaTime / (seconds) * (100f/ 60f);
        }
        else if (status < 0f)
        {
            status = 0f;
        }

        return status;
    }

    float grow(float status, float seconds)
    {
        if (status < 1f)
        {
            //sr.transform.localScale = new Vector3(fullScale, fullScale, 1f);
            status += Time.deltaTime / (seconds) * (100f / 60f);
        }
        else if (status > 1f)
        {
            status = 1f;
        }

        return status;
    }

}
