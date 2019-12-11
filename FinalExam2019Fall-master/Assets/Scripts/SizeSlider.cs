using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SizeSlider : MonoBehaviour
{
    public Slider sizeSlider;
    public static float sliderValue = 1f;
    public Text sliderText;

    void Start()
    {

    }

    void Update()
    {
        sliderValue = sizeSlider.value;

        sliderText.text = sizeSlider.value.ToString();
        
        PlayerPrefs.SetFloat("SliderValue", sliderValue);
    }
    void ChangeSlider()
    {

    }
}
