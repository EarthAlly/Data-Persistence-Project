using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsUIHandler : MonoBehaviour
{

    [SerializeField] private Slider slider;

    private PersistentObject persistentObject;
    private AudioSource audioSource;

    private void Start()
    {
        persistentObject = GameObject.Find("PersistentObject").GetComponent<PersistentObject>();
        audioSource = persistentObject.GetComponent<AudioSource>();
        
        slider.value = audioSource.volume;
    }
    private void Update()
    {
        audioSource.volume = slider.value;
    }
}
