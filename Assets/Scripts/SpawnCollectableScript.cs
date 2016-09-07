using UnityEngine;
using System.Collections;

public class SpawnCollectableScript : MonoBehaviour {

    public GameObject[] obj;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("Spawn", 0, 0.78f);
        Spawn();
    }

    void Spawn()
    {
        Instantiate(obj[Random.Range(0, obj.Length)], new Vector3(transform.position.x,
                                                        transform.position.y + Random.Range(-3, 3f),
                                                        transform.position.z), Quaternion.identity);
    }
}
