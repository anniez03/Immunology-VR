﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class CarouselRotationTest : MonoBehaviour {

    public GameObject carousel;

    //vive controller tracking and input
    public SteamVR_TrackedObject controller;
    private SteamVR_Controller.Device device
    {
        get { return SteamVR_Controller.Input((int)controller.index); }
    }


    private void Awake()
    {
        controller = GetComponent<SteamVR_TrackedObject>();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (device.GetHairTriggerDown())
        {
            carousel.transform.Rotate(carousel.transform.up, 45f);
            //carousel.transform.RotateAround(carousel.transform.position, carousel.transform.up, 45f);
        }

    }
}
