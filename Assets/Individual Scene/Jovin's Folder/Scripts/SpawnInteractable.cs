using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnInteractable : MonoBehaviour
{
    private Slider scaleSlider;
    private Slider rotateSlider;
    [SerializeField] float scaleMinValue;
    [SerializeField] float scaleMaxValue;
    [SerializeField] float rotMinValue;
    [SerializeField] float rotMaxValue;

    void Start()
    {
        // find the sliders by name
        //initialize the max and min value when starting
        // Add a listener to the slider when value is changed


        scaleSlider = GameObject.Find("ScaleS").GetComponent<Slider>();
        scaleSlider.minValue = scaleMinValue;
        scaleSlider.maxValue = scaleMaxValue;

        scaleSlider.onValueChanged.AddListener(ScaleSliderUpdate);


        rotateSlider = GameObject.Find("RotateS").GetComponent<Slider>();
        rotateSlider.minValue = rotMinValue;
        rotateSlider.maxValue = rotMaxValue;

        rotateSlider.onValueChanged.AddListener(RotateSliderUpdate);


    }

    void ScaleSliderUpdate(float value)
    {
        transform.localScale = new Vector3(value, value, value);
    }

    void RotateSliderUpdate(float value)
    {
        transform.localEulerAngles = new Vector3(transform.rotation.x, value, transform.rotation.z);
    }
}