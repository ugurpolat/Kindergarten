using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OneTwoPanel3 : MonoBehaviour
{
    
    public AudioSource clap;

    public Button btn_1;
    public Button btn_2;
    public Button btn_3;
    public Button btn_4;
    public GameObject panel3;
    public GameObject panel4;

    public int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        btn_1.onClick.AddListener(delegate { Next(); btn_1.interactable = false; });
        btn_2.onClick.AddListener(delegate { Next(); btn_2.interactable = false; });
        btn_3.onClick.AddListener(delegate { Next(); btn_3.interactable = false; });
        btn_4.onClick.AddListener(delegate { Next(); btn_4.interactable = false; });
    }

    // Update is called once per frame
    void Update()
    {
        if (counter == 4)
        {
            StartCoroutine(Waiter());
        }
    }

    public void Next()
    {
        clap.Play();
        counter++;

    }
    IEnumerator Waiter()
    {
        yield return new WaitForSeconds(1);
        panel3.SetActive(false);
        panel4.SetActive(true);

    }
}
