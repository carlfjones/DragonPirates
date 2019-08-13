using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostPool2 : MonoBehaviour
{
    public int ghostPoolSize = 5;
    public GameObject ghostPrefab;
    public float spawnRate = 4f;
    public float ghostMin = -1f;
    public float ghostMax = 3.5f;

    private GameObject[] ghosts;
    private Vector2 objectPoolPosition = new Vector2(-30f, 1f);
    private float timeSinceLastSpawned;
    private float spawnXPosition = 15f;
    private int currentghost = 0;


    // Start is called before the first frame update
    void Start()
    {
        ghosts = new GameObject[ghostPoolSize];
        for (int i = 0; i < ghostPoolSize; i++)
        {
            ghosts[i] = (GameObject)Instantiate(ghostPrefab, objectPoolPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastSpawned += Time.deltaTime;
        if (GameControl.instance.gameOver == false && timeSinceLastSpawned >= spawnRate)
        {
            timeSinceLastSpawned = 0;
            float spawnYPosition = Random.Range(ghostMin, ghostMax);
            ghosts[currentghost].transform.position = new Vector2(spawnXPosition, spawnYPosition);
            currentghost++;
            if (currentghost >= ghostPoolSize)
            {
                currentghost = 0;
            }
        }
    }
}
