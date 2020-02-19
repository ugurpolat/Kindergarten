using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneTwoPanel1 : MonoBehaviour
{
    public AudioSource applause;
    public GameObject panel1;
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
        
        applause.Play();



        StartCoroutine(Waiter());


    }

    public void WrongAnswer()
    {
        sad_1.Play();
    }

    IEnumerator Waiter()
    {
        yield return new WaitForSeconds(2);
        panel1.SetActive(false);
        panel2.SetActive(true);

    } 

    
}
