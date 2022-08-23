using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.tag == "Character")
        {
            CoinText.coinAmount += 1;
            Destroy(gameObject);
        }
    }

}
