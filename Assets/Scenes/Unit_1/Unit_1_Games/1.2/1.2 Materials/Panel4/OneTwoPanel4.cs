using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OneTwoPanel4 : MonoBehaviour
{
    public AudioSource applause;

    public GameObject Next_Button;

    public Button btn_1;
    public Button btn_2;

    bool a = false;
    bool b = false;

    public void Step_1()
    {
        applause.Play();
        a = true;
        if (a == true & b == true)
        {
            Next_Button.SetActive(true);
        }
    }
    public void Step_2()
    {
        applause.Play();
        b = true;
        if (a == true &  b == true)
        {
            Next_Button.SetActive(true);
        }
    }

}
