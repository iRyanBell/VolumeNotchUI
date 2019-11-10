using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInteractivity : MonoBehaviour
{
	private float _sensitivity;
	private Vector3 _mouseReference;
	private Vector3 _mouseOffset;
	private Vector3 _rotation;
	private bool _isRotating;
	public GameObject notches;

	void Start()
	{
		_sensitivity = 0.1f;
		_rotation = Vector3.zero;
	}

	void Update()
	{

		if (Input.GetMouseButtonDown(0))
		{
			_isRotating = true;
			_mouseReference = Input.mousePosition;
		}

		if (Input.GetMouseButtonUp(0))
		{
			_isRotating = false;
		}

		if (_isRotating)
		{
			_mouseOffset = (Input.mousePosition - _mouseReference);
			_rotation.z = -(_mouseOffset.x + _mouseOffset.y) * _sensitivity;
			notches.transform.Rotate(_rotation);

			_mouseReference = Input.mousePosition;
		}
		else
		{
			Quaternion r = notches.transform.rotation;
			r.z *= 0.95f;
			notches.transform.rotation = r;
		}
	}
}