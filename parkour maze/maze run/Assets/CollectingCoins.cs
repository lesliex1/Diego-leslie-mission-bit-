using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectingCoins : MonoBehaviour
{
    public int coins;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnTriggerEnter(Collider Col)
    {
      if(Col.gameObject.tag == "Coins")
        {
            Debug.Log("Coin Collected!");
            coins = coins + 1;
            Col.gameObject.SetActive(false);
        }  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
