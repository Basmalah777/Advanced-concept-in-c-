using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListMethodsExample : MonoBehaviour
{
    void Start()
    {
        //part 4
        List<int> numbers = new List<int> { 3, 1, 4, 1, 5, 9 };
        numbers.Sort((x, y) => y.CompareTo(x)); 
        Debug.Log(string.Join(", ", numbers));

        //part 5
        List<int> numbers2 = new List<int> { 3, 1, 4, 1, 5, 9, 2, 6 };
        List<int> filteredNumbers = numbers2.FindAll(x => x % 2 == 0); 
        Debug.Log(string.Join(", ", filteredNumbers));
    }
}
