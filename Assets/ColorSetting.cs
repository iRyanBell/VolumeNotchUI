using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSetting : MonoBehaviour
{
	Renderer r;
	public GameObject ball;
	void Start()
	{
		r = GetComponent<Renderer>();
		r.material.color = Color.gray;
	}

	void Update()
	{
		if (ball.transform.position.x > transform.position.x)
		{
			r.material.color = Color.green;
		}
		else
		{
			r.material.color = Color.gray;
		}
	}
}
