using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       Debug.Log("Hello Box! : This happens only once in the beggining");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("This happens every FPS");
    }
}
