using UnityEngine;
using System.Collections;

public class LevelAdvancerSpawnerScript : MonoBehaviour {

    public GameObject[] obj;
    public int doSpawn = 0;
    private float timePassed = 0f;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("Spawn", 0, 0.26f);
        Spawn();
    }

    void Spawn()
    {
        if (doSpawn == 1)
        {
            Instantiate(obj[Random.Range(0, obj.Length)], new Vector3(transform.position.x,
                                                          transform.position.y,
                                                          transform.position.z), Quaternion.identity);
            doSpawn = 2;
        }
    }

    void Update()
    {
        timePassed += Time.deltaTime;
        if ((timePassed > 45 && doSpawn == 0) || Input.GetKeyDown(KeyCode.S))
        {
            doSpawn = 1;
        }
    }
}
