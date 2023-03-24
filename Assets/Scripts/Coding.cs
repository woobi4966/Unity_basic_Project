using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coding : MonoBehaviour
{
    int result;
    // Start is called before the first frame update
    void Start()
    {
        result = Plus(3, 4);
        print(result);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int Plus(int number1, int number2){
        return number1 + number2;
    }

}
