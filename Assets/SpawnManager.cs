using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject sharkPrefab;
    public Transform spawnPoint;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnShark()
    {
        Instantiate(sharkPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
