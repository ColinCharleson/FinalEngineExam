using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	Camera cam;

	float xView, yView;

	public GameObject bullet;
	public void Start()
	{
		cam = GetComponentInChildren<Camera>();
	}
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Rigidbody bulletRb = Instantiate(bullet, cam.transform.position, Quaternion.identity).GetComponent<Rigidbody>();
			bulletRb.AddForce(cam.transform.forward * 320f, ForceMode.Impulse);
			bulletRb.AddForce(transform.up, ForceMode.Impulse);
		}


		if (Input.GetKey(KeyCode.LeftArrow))
			yView -= Time.deltaTime * 8;
		if (Input.GetKey(KeyCode.RightArrow))
			yView += Time.deltaTime * 8;
		if (Input.GetKey(KeyCode.UpArrow))
			xView -= Time.deltaTime * 8;
		if (Input.GetKey(KeyCode.DownArrow))
			xView += Time.deltaTime * 8;

		yView = Mathf.Clamp(yView, -20, 20);
		xView = Mathf.Clamp(xView, -50, 50);
		cam.transform.rotation = Quaternion.Euler(xView, yView, 0);
	}
}
