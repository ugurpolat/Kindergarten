using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class OnePanel1 : MonoBehaviour
{

    public AudioSource ques_1;
    public AudioSource ques_2;

    public AudioSource cat_meow;
    public AudioSource dog_barking;

    public GameObject panel1;
    public GameObject panel2;

    public Button dog_Button;
    public Button cat_Button;

    int count = 0;


    // Start is called before the first frame update
    void Start()
    {
        dog_Button.interactable = false;
        cat_Button.interactable = false;
        ques_1.Play();

        
    }

    // Update is called once per frame
    void Update()
    {
        if (ques_1.isPlaying == false)
        {
            cat_Button.interactable = true;

        }

        if (count == 1)
        {
            if (ques_2.isPlaying == false)
            {
                dog_Button.interactable = true;
            }

        }
    }

    public void Cat()
    {
        count = 1;
        cat_meow.Play();
        ques_2.PlayDelayed(1.5f);
    }
    public void Dog()
    {
        cat_meow.Stop();
        dog_barking.Play();
        panel1.SetActive(false);
        panel2.SetActive(true);
        

    }
    public void Question()
    {

    }

}
