using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleController : MonoBehaviour
{
    FieldManager fieldManager = new FieldManager();
    [SerializeField] int testInt;
    // Start is called before the first frame update
    void Start()
    {
        fieldManager.RowHieght = 5;
        testInt = fieldManager.RowHieght;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
