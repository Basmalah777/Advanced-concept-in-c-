using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MulticastDelegateExample : MonoBehaviour
{
    // Define delegate
    delegate void MathOperation(int number);

    void Start()
    {
        MathOperation operation = null;
        // Add methods to delegate
        operation += DoubleNumber;
        operation += SquareNumber;
        operation += CubeNumber;

        // Invoke the delegate
        operation(5);
    }

    void DoubleNumber(int number) => Debug.Log("Double: " + (number * 2));
    void SquareNumber(int number) => Debug.Log("Square: " + (number * number));
    void CubeNumber(int number) => Debug.Log("Cube: " + (number * number * number));
}
