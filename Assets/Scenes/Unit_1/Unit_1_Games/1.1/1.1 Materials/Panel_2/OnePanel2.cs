using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnePanel2 : MonoBehaviour
{
    public Button[] Buttons;
    public GameObject[] images;
    public AudioSource click;
    public int count = 0;
    public GameObject Next_Scene_Button;

    // Start is called before the first frame update
    void Start()
    {
        Buttons[0].onClick.AddListener(delegate { Fences(0); });
        Buttons[1].onClick.AddListener(delegate { Fences(1); });
        Buttons[2].onClick.AddListener(delegate { Fences(2); });
    }

    public void Fences(int t)
    {
        click.Play();
        images[t].SetActive(true);
        Buttons[t].enabled = false;
        count++;
    }

    // Update is called once per frame
    void Update()
    {
        if (count == 3)
        {
            Next_Scene_Button.SetActive(true);
        }  
    }
}
