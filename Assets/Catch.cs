using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catch : MonoBehaviour
{
	void Update()
	{
		if (transform.position.y < -3)
		{
			Vector3 pos = transform.position;
			pos.y = 3;
			pos.x = -2;
			transform.position = pos;
		}
	}
}
