﻿using UnityEngine;
using System.Collections;

public class pacBlink2 : MonoBehaviour {

	float speed = 1100f;
	float reset = 0.2f;
	float timer = 0.2f;
	float pause = 0.1f;
	bool down = false;

	// Update is called once per frame
	void Update ()
	{
		if (down == false)
		{
			pause -= Time.deltaTime;
			if (pause <= 0)
			{
				transform.Translate(0, speed*Time.deltaTime, 0);
				timer -= Time.deltaTime;
				
				if (timer <= 0)
				{
					down = true;
					timer = reset;
					pause = 0.1f;
				}
			}
		}
		else
		{
			transform.Translate(0, -speed*Time.deltaTime, 0);
			timer -= Time.deltaTime;
			
			if (timer <= 0)
			{
				down = false;
				timer = reset;
			}
		}
	}
}
