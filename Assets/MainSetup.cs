using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSetup : MonoBehaviour
{

    public GameObject checkerOriginal;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 2; i++)
        {
            GameObject checker_instance = Instantiate(checker);
            checker_instance.transform.position(new Vector2(i*2, 0));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
