using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie_creator : MonoBehaviour
{
    public GameObject zombie;
    private Vector3 vector;
    public int init_x;
    public int end_x;
    public int init_y;
    public int end_y;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 50; i++)
        {
            vector= new Vector3(UnityEngine.Random.Range(init_x, end_x), -5, UnityEngine.Random.Range(init_y, end_y));
            Instantiate(zombie, vector, transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
