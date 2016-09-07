using UnityEngine;
using System.Collections;

public class GroundSpawnScript_NoHoles : GroundSpawnScript
{

    protected override void Spawn()
    {
        Instantiate(obj[Random.Range(0, obj.Length)], transform.position, Quaternion.identity);
    }
}
