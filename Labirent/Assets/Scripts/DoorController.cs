using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField] private KeyController.KeyType keyType;
     Animator anim;
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
    } 
    
   private void OnTriggerEnter(Collider other) 
   {
    if(other.tag == "Karakter")
    {
        anim.SetTrigger("openclose");
    } 
   }
  /*  private void OnTriggerExit(Collider other) 
   {
    if(other.tag == "Karakter")
    {
        anim.SetTrigger("openclose");
    } 
   }*/

   public KeyController.KeyType GetKeyType()
    {
        return keyType;    
    }
    public void OpenDoor(){
        anim.SetTrigger("openclose");
    }
}
