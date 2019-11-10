using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vol : MonoBehaviour
{
	public Text volDisplay;

	void Update()
	{
		GameObject[] notches = GameObject.FindGameObjectsWithTag("notch");
		int vol = 0;

		for (int i = 0; i < notches.Length; i++)
		{
			Color notchColor = notches[i].GetComponent<Renderer>().material.color;
			if (notchColor == Color.green)
			{
				vol += 1;
			}
		}

		volDisplay.text = vol > 0 ? "Volume: " + vol : "Volume: Muted";
	}
}
