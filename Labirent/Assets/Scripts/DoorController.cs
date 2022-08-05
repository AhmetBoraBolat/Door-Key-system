using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
   [SerializeField] private float openangle;

   Quaternion startRot;
   Quaternion newRot;
    void Start()
    {
        startRot = this.transform.rotation;
        Quaternion newRot = Quaternion.Euler(this.transform.eulerAngles.x,openangle,this.transform.eulerAngles.z);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter(Collision other) {
       /*if(other.gameObject.CompareTag("Karakter"))
        {
           
        } */
         this.transform.rotation = Quaternion.Lerp(startRot,newRot,0.2f);
    }

// çalışmadı sonra kontrol et
}
