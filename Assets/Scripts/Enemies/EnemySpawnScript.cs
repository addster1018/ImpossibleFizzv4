using UnityEngine;
using System.Collections;

public class EnemySpawnScript : MonoBehaviour {

    public GameObject[] obj;
    public float spawnChance = 1f;
    private float timePassed = 0f;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("Spawn", 0, 0.26f);
        Spawn();
    }

    void Spawn()
    {
        if (Random.Range(0f, 1f) < spawnChance)
        {
            Instantiate(obj[Random.Range(0, obj.Length)], new Vector3(transform.position.x, 
                                                          transform.position.y + Random.Range(-3, 3f), 
                                                          transform.position.z), Quaternion.identity);
        }
        spawnChance = Mathf.Abs(1f - (Mathf.Exp(-1f * timePassed / 60f)));
    }

    void Update()
    {
        timePassed += Time.deltaTime;
    }
}
