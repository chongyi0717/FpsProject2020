using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie_creator : MonoBehaviour
{
    public GameObject zombie;
    private Vector3 vector;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 50; i++)
        {
            vector= new Vector3(UnityEngine.Random.Range(-70.0f, 10.0f), 0, UnityEngine.Random.Range(14.0f, 62.0f));
            Instantiate(zombie, vector, transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
