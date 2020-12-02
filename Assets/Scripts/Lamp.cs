using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour, IInteract
{
    private Light _light;
    
    private float _defaultIntensity;
    private int _turnedOffIntensity=0;

    private void Start()
    {
        _light = GetComponent<Light>();
        _defaultIntensity = _light.intensity;
    }

    void Light()
    {
        if (_light.intensity == _defaultIntensity)
        {
            _light.intensity = _turnedOffIntensity;
            Debug.Log("On");
        }
        else if (_light.intensity == _turnedOffIntensity)
        {
            _light.intensity = _defaultIntensity;
            Debug.Log("Off");
        }
    }
    
    public void Interact()
    {
        Light();
    }
}
