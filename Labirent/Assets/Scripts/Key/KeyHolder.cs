using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyHolder : MonoBehaviour
{
    private List<KeyController.KeyType> keyList;
    private void Awake() {
        keyList = new List<KeyController.KeyType>();
    }
    public bool containsKey(KeyController.KeyType keyType){
        return keyList.Contains(keyType);
    } 
    public void addKey(KeyController.KeyType keyType)
    {
        Debug.Log("added key :"+ keyType);
        keyList.Add(keyType);
        Debug.Log(containsKey(keyType));
    }
     public void removeKey(KeyController.KeyType keyType)
    {
        keyList.Remove(keyType);
    }
    
    private void OnCollisionEnter(Collision other) {
     KeyController key = GetComponent<KeyController>();
        if( key !=null){
            addKey(key.GetKeyType());
            Destroy(key.gameObject);
        }
    }
}