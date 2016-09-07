using UnityEngine;
using System.Collections;

public class GroundSpawnScript : MonoBehaviour {

    public GameObject[] obj;
    public float spawnChance = 1f;
    protected float timePassed = 0f;
    protected bool did = false;

	// Use this for initialization
	protected void Start () {
        InvokeRepeating("Spawn", 0, 0.26f);
	}
	
    protected virtual void Spawn()
    {
        if (Random.Range(0f, 1f) < spawnChance)
        {
            Instantiate(obj[Random.Range(0, obj.Length)], transform.position, Quaternion.identity);
        }
        spawnChance = Mathf.Exp(-1f * timePassed / 60f);
    }

    protected virtual void Update()
    {/*
        //Debug.Log(timePassed);
        if (timePassed >= 5f && !did)
        {
            Debug.Log("level");
            did = true;
            LevelAnnouncementScript.IncreaseLevel();
        } else
        {*/
            timePassed += Time.deltaTime;
        //}
    }
}
