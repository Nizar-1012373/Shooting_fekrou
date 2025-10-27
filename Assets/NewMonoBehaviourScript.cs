using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NewMonoBehaviourScript : MonoBehaviour
{

    bool Moveforward = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.A))
        {
            Moveforward = true;
        }
        if (Moveforward)
        {
            transform.Translate(Vector3.forward * 30 * Time.deltaTime);
        }

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "cube(1)")
        {
            transform.position = new Vector3(0, 0, 2);

        }
    }
}
