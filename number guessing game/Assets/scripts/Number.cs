using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Number : MonoBehaviour
{
    private int guess = 5;
    private int minValue = 1;
    private int maxValue = 10;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("welcome to the sexy number guessing game");
        Debug.Log("the number range is from " + minValue + " and " + maxValue );
        Debug.Log("i will guess a number and you say if it is higher or lower then : " +guess+ "");
        Debug.Log("push arrow keys depending on higher(up arrow) or lower and enter if correct");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            minValue = guess;
            guess = (maxValue + minValue) / 2;
            Debug.Log("is this it or is it higher or lower than: " + guess);
        }
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            maxValue = guess;
            guess = (maxValue +minValue) / 2;
            Debug.Log("is it higher or lower or am i right: " + guess);
        }
    }
}
