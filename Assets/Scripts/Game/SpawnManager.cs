using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public List<Transform> spawns = new List<Transform>();

    public GameObject playerPrefab = null;

    private void Start()
    {
        // Instantiate the player at a randomly chosen spawn point
        //
        // TODO: make this work for networked by getting a list of players
        // and spawning each player at a random location through that
        int spawn = Random.Range(0, spawns.Count);

        Instantiate(playerPrefab, spawns[spawn].position, spawns[spawn].rotation);
    }
}