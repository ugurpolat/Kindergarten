using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OneTwoPanel2 : MonoBehaviour
{

    public GameObject img_1;
    public GameObject img_2;
    
    public GameObject panel2;
    public GameObject panel3;

    public Button btn_1;
    public Button btn_2;

    public AudioSource clap;
    public AudioSource sad;
    public AudioSource question;

    int i = 0;
    int u = 0;

    // Start is called before the first frame update
    void Start()
    {
        btn_1.interactable = false;
        btn_2.interactable = false;
        question.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (question.isPlaying == false)
        {
            btn_1.interactable = true;
            btn_2.interactable = true;

        }


    }

    public void Step_1()
    {
        img_1.SetActive(true);
        clap.Play();
        i = 1;
        if (u == 1)
        {
            StartCoroutine(Waiter());
        }
    }

    public void Step_2()
    {
        img_2.SetActive(true);
        clap.Play();
        u = 1;
        if (i == 1)
        {
            StartCoroutine(Waiter());
        }
    }

    IEnumerator Waiter()
    {
        yield return new WaitForSeconds(1);
        panel2.SetActive(false);
        panel3.SetActive(true);

    }
}
