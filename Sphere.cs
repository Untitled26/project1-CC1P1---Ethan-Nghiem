using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{

    bool var3 = false;

    // Start is called before the first frame update
    void Start()
    {
        var3 = true;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(var3);
    }
}
