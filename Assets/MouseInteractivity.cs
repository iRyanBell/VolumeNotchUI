using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInteractivity : MonoBehaviour
{
	private float _sensitivity;
	private Vector3 _mouseReference;
	private Vector3 _mouseOffset;
	private bool _isRotating;
	public GameObject notches;

	void Start()
	{
		_sensitivity = 0.1f;
	}

	void Update()
	{

		if (Input.GetMouseButtonDown(0))
		{
			_mouseReference = Input.mousePosition;
			_isRotating = true;
		}

		if (Input.GetMouseButtonUp(0))
		{
			_isRotating = false;
		}

		if (_isRotating)
		{
			_mouseOffset = (Input.mousePosition - _mouseReference);
			float rot = -(_mouseOffset.x + _mouseOffset.y) * _sensitivity;
			rot = Mathf.Max(rot, -30);
			rot = Mathf.Min(rot, 30);
			Quaternion q = notches.transform.rotation;
			notches.transform.rotation = Quaternion.Slerp(q, Quaternion.Euler(0, 0, rot), Time.time * 0.5f);
		}
		else
		{
			Quaternion r = notches.transform.rotation;
			r.z *= 0.98f;
			notches.transform.rotation = r;
		}
	}
}