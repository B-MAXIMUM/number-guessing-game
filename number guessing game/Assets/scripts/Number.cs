using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Number : MonoBehaviour
{
    private int guess;
    private int minValue = 1;
    private int maxValue = 10;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("welcome to the sexy number guessing game");
        Debug.Log("the number range is from" + minValue "and" + maxValue );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
