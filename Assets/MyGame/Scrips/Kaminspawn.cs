using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kaminspawn : MonoBehaviour
{
    public GameObject kaminPrefab;
    public GameObject spawnPoint;

    public float spawnRate = 3f;
    private float nextSpawn = 4f;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
       if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            SpawnTheKamine();
        }
    }
    private void SpawnTheKamine()
    {
        var clones = Instantiate(kaminPrefab);
        clones.GetComponent<Transform>().SetParent(spawnPoint.GetComponent<Transform>(), false);
        clones.GetComponent<Transform>().localPosition = new Vector3(Random.Range(-400, 400), 0, 0);
        clones.GetComponent<Transform>().localRotation = Quaternion.identity;
        clones.GetComponent<Transform>().localScale = new Vector3(0.5f, 0.5f, 0.5f);

    }
}
