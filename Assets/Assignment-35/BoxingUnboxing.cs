using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxingUnboxing : MonoBehaviour
{
  void Start()
    {
        int health = 100;
        // Boxing
        object boxedHealth = health;
        // Unboxing and modify
        int unboxedHealth = (int)boxedHealth;
        unboxedHealth += 50;

        Debug.Log("Original int value: " + health);
        Debug.Log("Boxed value: " + boxedHealth);
        Debug.Log("Unboxed and modified value: " + unboxedHealth);
    }
}
