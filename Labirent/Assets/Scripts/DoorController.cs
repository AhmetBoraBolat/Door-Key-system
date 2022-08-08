using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField] private KeyController.KeyType keyType;
     Animator anim;
     KeyHolder keyh;
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
        keyh = GameObject.Find("Key").GetComponent<KeyHolder>();
    }  
   public KeyController.KeyType GetKeyType()
    {
        return keyType;    
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Karakter")){
            if(keyh.containsKey(GetKeyType())){
                anim.SetTrigger("openclose");
                //keyh.removeKey(GetKeyType());
            }
            else{
                Debug.Log("ANAHTARI BUL");
            }
            //Debug.Log(keyh.containsKey(GetKeyType()));
        }
    }
    // karakter triggerdan çıktığında anahtar listeden silinir ve kapı bir daha tetiklenmez eğer karakter trigger içine girip
    //  kapıdan geçmeden trigger'dan çıkarsa anahtar listeden silindiği için kapıdan geçemez. Buna pozisyonla alakalı bir koşul ekle!
    private void OnTriggerExit(Collider other) {
        if(keyh.containsKey(GetKeyType())){
            anim.SetTrigger("openclose");
            keyh.removeKey(GetKeyType());
        }
    }
}
/* keyh = GameObject.Find("Key").GetComponent<KeyHolder>(); TANIMLAMASINI YAPMADIĞIM İÇİN COLLİSİONA GİRİLDİĞİNDE HATA ALIYORDUM. START
    FONKSİYONU İÇERİSİNDE TANIMLAMAYI YAPIP ÇAĞIRDIM VE SORUN ÇÖZÜLDÜ */