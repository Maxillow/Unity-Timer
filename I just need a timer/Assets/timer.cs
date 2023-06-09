using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using System.Threading;

public class timer : MonoBehaviour {

    public TMP_Text aaa;
    public TMP_Text words;
    public AudioSource beep;
    public float num = 59;
    public bool toggle = true;

    private void Start()
    {
        StartCoroutine(Timer());
    }

    IEnumerator Timer()
    {
        while (true)
        {
            if (toggle)
            {
                while (num > 0)
                {
                    if (num >= 10)
                    {
                        aaa.text = "0:" + num.ToString();
                    }
                    else
                    {
                        aaa.text = "0:0" + num.ToString();
                    }

                    if (num < 5)
                    {
                        beep.Play();
                    }

                    yield return new WaitForSeconds(1f);
                    num--;
                }

                words.text = "Break";
                toggle = false;
                num = 5;
                aaa.text = "0:05";
            }
            else
            {
                while (num > 0)
                {
                    aaa.text = "0:0" + num.ToString();
                    yield return new WaitForSeconds(1f);
                    num--;
                }

                words.text = "Timer";
                toggle = true;
                num = 59;
            }
        }

    }

}
