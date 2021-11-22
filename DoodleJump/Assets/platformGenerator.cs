using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformGenerator : MonoBehaviour
{
    public GameObject platformPrefab;

    public int platformsCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Generator(float height)
    {
        
        
            GameObject platform;
            Vector3 platformPosition = new Vector3();
            platformPosition.y = height-2;
            platformPosition.x = Random.Range(-9, 9);
            platformPosition.z = -1;
            Instantiate(platformPrefab, platformPosition, Quaternion.identity);
        //platformsCount += 1;
            platformPosition.x = Random.Range(-9, 9);
            platformPosition.y = height + 0f;
            Instantiate(platformPrefab, platformPosition, Quaternion.identity);
            platformsCount += 1;
            platformPosition.x = Random.Range(-9, 9);
            platformPosition.y = height+2F;
            Instantiate(platformPrefab, platformPosition, Quaternion.identity);
            platformsCount += 1;
            platformPosition.x = Random.Range(-9, 9);
            platformPosition.y = height + 4f;
            Instantiate(platformPrefab, platformPosition, Quaternion.identity);
            platformsCount += 1;
            platformPosition.x = Random.Range(-9, 9);
            platformPosition.y = height + 6f;
            Instantiate(platformPrefab, platformPosition, Quaternion.identity);
            platformsCount += 1;
        
        

    }
}
