using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	private void OnCollisionEnter(Collision other)
	{
		Destroy(this.gameObject);

		if (other.collider.tag == "Ducks")
		{
			other.gameObject.SetActive(false);
			GameManager.instance.UpdateScore(100);
			ObjectPooler.instance.ducksAlive -= 1;
		}
	}
}
