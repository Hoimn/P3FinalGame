using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTester : MonoBehaviour
{
    public AttributesManager playerAtm;
    public AttributesManager enemyAtm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Deal player damage to the enemy health
        if(Input.GetKeyDown(KeyCode.C))
        {
            playerAtm.DealDamage(enemyAtm.gameObject);
        }

        //Deal enemy gamage to the player health
        if(Input.GetKeyDown(KeyCode.V))
        {
            enemyAtm.DealDamage(playerAtm.gameObject);
        }
    }
}
