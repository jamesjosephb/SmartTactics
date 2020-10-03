using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldManager : MonoBehaviour
{
    Vector3 testPos;


    Transform testTrans;
    // Start is called before the first frame update
    void Start()
    {
        testPos = transform.position;
        print(testPos);
        testPos = new Vector3(0f, 10f, 0f);
        print(testPos);
        testTrans = transform;
        testTrans.position = new Vector3(0f, 10f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
