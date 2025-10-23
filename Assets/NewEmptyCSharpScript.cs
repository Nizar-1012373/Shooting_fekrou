using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class NewEmptyCSharpScript: MonoBehaviour
{
    void Start()
    {

        GameObject obstakel = new GameObject("obstakel");
        Debug.Log(GameObject.Find("obstakel").transform.position);
        
    }
    void Update()
    {
        
        if (Input.GetKey(KeyCode.Space))
        {
            for (int i = 0; i < 2; i++)
            {
                transform.Translate(0, 0, i);
            }
        }
        
    }



}
