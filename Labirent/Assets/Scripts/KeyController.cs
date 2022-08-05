using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour
{
    [SerializeField] private static int keyNumber;

    private bool AnahtarAlindiMi = false;

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("Karakter"))
        {
            anahtar();
            Destroy(this.gameObject);
            Debug.Log(AnahtarAlindiMi);
        }
    }

    
    private void anahtar()
    {
       AnahtarAlindiMi = true;
    }
    
}
