using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public int DMG;
    float cooldown = 0f;

    private void OnCollisionEnter(Collision collision)
    {
        Health health = collision.gameObject.GetComponent<Health>();
        if (health != null )
        {
            health.TakeDamage(DMG);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cooldown -= Time.deltaTime;
    }

    private void OnCollisionStay(Collision collision)
    {
        Health health = collision.gameObject.GetComponent< Health>();
        if (cooldown <= 0f ) 
        {
            if (health != null)
            {
                health.TakeDamage(DMG);
            }
            cooldown = 1f;
        }
    }
}
