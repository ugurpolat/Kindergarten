using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneTwoPanel1 : MonoBehaviour
{
    public AudioSource applause;
    public GameObject panel2;
    public AudioSource sad_1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TrueAnswer()
    {
        sad_1.Stop();
        applause.Play();

        panel2.SetActive(true);
    }

    public void WrongAnswer()
    {
        sad_1.Play();
    }
}
