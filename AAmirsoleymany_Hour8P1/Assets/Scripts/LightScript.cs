using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{

	Light mylight;

	// Use this for initialization
	void Start()
	{
		mylight = GetComponent<Light>();
	}

	// Update is called once per frame
	void Update()
	{
		
		if (Input.GetKeyUp(KeyCode.L))
		{
			GetComponent<Light>().enabled = !GetComponent<Light>().enabled;
		}
	}
	//
	 //* THIS TOOK TWO HOURS. WHY IS GET COMPONENT SO OBNOXIOUSLY COMPLICATED BY GOD
	 //* THE BOOK HELPS VERY LITTLE FOR THIS
	 //* THE WEBSITES LINKED ARE NO BETTER AND ARE OUTDATED FOR SOFTWARE BY TWO YEARS */*
	 

}