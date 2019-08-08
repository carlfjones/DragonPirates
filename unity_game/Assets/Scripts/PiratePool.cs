using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiratePool : MonoBehaviour
{
    public int piratePoolSize = 5;
    public GameObject piratePrefab;
    public float spawnRate = 4f;
    public float pirateMin = -1f;
    public float pirateMax = 3.5f;

    private GameObject[] pirates;
    private Vector2 objectPoolPosition = new Vector2(-15f, -25f);
    private float timeSinceLastSpawned;
    private float spawnXPosition = 10f;
    private int currentPirate = 0;


    // Start is called before the first frame update
    void Start()
    {
        pirates = new GameObject[piratePoolSize];
        for (int i = 0; i < piratePoolSize; i++)
        {
            pirates[i] = (GameObject)Instantiate(piratePrefab, objectPoolPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastSpawned += Time.deltaTime;
        if (GameControl.instance.gameOver == false && timeSinceLastSpawned >= spawnRate)
        {
            timeSinceLastSpawned = 0;
            float spawnYPosition = Random.Range(pirateMin, pirateMax);
            pirates[currentPirate].transform.position = new Vector2(spawnXPosition, spawnYPosition);
            currentPirate++;
            if (currentPirate >= piratePoolSize)
            {
                currentPirate = 0;
            }
        }
    }
}
