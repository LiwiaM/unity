using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTestScript2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello Box! : This hapens only once in the beggining");
        Debug.Log("This is the second messenge");

        // Använder namnet kubobjekt
        transform.name ="SUPERCUBE";

        // Ändra på positionen en gång
        transform.position = new Vector3(3f, 1.5f, 0f);
        transform.position += Vector3.right * Time.deltaTime;
        

        // rotate 45 degrees
        /*Vector3 rotationToAdd = new Vector3(3f, 1.5f, 0f);
        transform.Rotate(rotationToAdd);*/
          
        //transform.rotate(0f, 45f, 0f);   
    }

    // Update is called once per frame
    void Update()
    {
        // Denna kommando skrivs ut varje frame per sekund
        // Debug.Log("This happens every FPS");
        /*
         
         */
    }

    void myFunction() { }
}
