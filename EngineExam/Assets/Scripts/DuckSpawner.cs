using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckSpawner : MonoBehaviour
{
    void Update()
    {
        if(ObjectPooler.instance.ducksAlive < GameManager.instance.maxDucks)
		{
         ObjectPooler.instance.SpawnFromPool("Duck", new Vector3(Random.Range(-20, -30), Random.Range(4,14), 0), Quaternion.Euler(0,0,-90));
		}
    }
}
