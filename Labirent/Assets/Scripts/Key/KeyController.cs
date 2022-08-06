using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour
{
     [SerializeField] private KeyType keyType;
    public enum KeyType
    {
        door1,
        door2,
        door3
    }   
    public KeyType GetKeyType()
    {
        return keyType;    
    }
}
