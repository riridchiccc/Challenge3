using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinCount = 1;
    [SerializeField]GameObject gm;
    bool hasHitCoin = false;
    private void Update()
    {
        if (hasHitCoin == true)
        {
            coinCount++;
            gm.GetComponent<GameManager>().AddScore(coinCount);
            Destroy(gameObject);
        }
        else
            return;
       
    }

     private void OnTriggerEnter(Collider col)
     {
       if (col.CompareTag("Player"))
       {
            hasHitCoin = true;
        
 
       }
        else
        {
            hasHitCoin = false;
        }
     }
  
}
