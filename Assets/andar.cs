using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class andar : MonoBehaviour
{
	bool isLeftButtonDown;
	bool isRightButtonDown;
	bool isMiddleButtonDown;
	Vector3 m;
	// Start is called before the first frame update
	void Start()
	{
		isLeftButtonDown = false;
		isRightButtonDown = false;
		isMiddleButtonDown = false;
		m.x = 0.0f;
		m.y = 0.0f;
		m.z = 0.0f;
	}

	void Movimento(Vector3 m)
	{
		transform.Translate(m);

	}
	

	// Update is called once per frame
	void Update()

	{
		if (Input.GetKey(KeyCode.P))
		{
			m.y = 0.1f;
			Movimento(m);
			m.y = 0.0f;
		}

		if (Input.GetKey(KeyCode.W))
		{
			m.x = 0.1f;
			Movimento(m);

			m.x = 0.0f;
		}
		if (Input.GetKey(KeyCode.S))
		{

			m.x = -0.1f;
			Movimento(m);
		
			m.x = 0.0f;

		}
		if (Input.GetKey(KeyCode.D))
		{
			m.z = -0.1f;
			Movimento(m);
			
			m.z = 0.0f;
		}
		if (Input.GetKey(KeyCode.A))
		{
			m.z = 0.1f;
			Movimento(m);
			m.z = 0.0f;

		}
		
	}


}
