using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowData : MonoBehaviour
{

  


    public Text Size;
    public Text Speed;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

    
        Speed.text = "Speed: " + PlayerPrefs.GetFloat("SpeedValue");
        Size.text = "Size " + PlayerPrefs.GetFloat("SliderValue");

    }

}
