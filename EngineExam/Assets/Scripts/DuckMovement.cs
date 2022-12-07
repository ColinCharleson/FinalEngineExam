using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckMovement : MonoBehaviour
{
    Rigidbody rb;
    float startHeight;
    Vector3 flapforce = new Vector3(0.2f,0.5f,0f);
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startHeight = this.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.y <= startHeight - 2)
		{
            rb.velocity = Vector3.zero;
            rb.AddForce(flapforce, ForceMode.Impulse);
		}

        if (transform.position.x >= 30)
        {
            gameObject.SetActive(false);
            ObjectPooler.instance.ducksAlive -= 1;
            GameManager.instance.Damage(1);
        }
    }
}
