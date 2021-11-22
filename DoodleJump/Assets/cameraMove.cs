using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cameraMove : MonoBehaviour
{
    // Start is called before the first frame update
    public doodler doodler;
    public platformGenerator platformGenerator;
    public float TimeToBield;

    void Start()
    {
            Debug.LogWarning(transform.position.x);
    }

    // Update is called once per frame
    void Update()
    {
        TimeToBield -= Time.deltaTime;
        if (doodler.transform.position.y > transform.position.y)
        {
            Vector3 newPos = new Vector3(transform.position.x, doodler.transform.position.y, transform.position.z);
            transform.position = newPos;
        }
        if(TimeToBield<0)
        {
            platformGenerator.Generator(transform.position.y);
            TimeToBield = 3.5f;
        }
        if (doodler.transform.position.y < transform.position.y-5)
        {
            Debug.LogWarning("You Lost");
            SceneManager.LoadScene(0);

        }



    }
}
