using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    // Start is called before the first frame update
    public int maxHp = 10;
    public int currentHp;

    void Start()
    {
        currentHp = maxHp;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(int amount){
        currentHp -= amount;
        if (currentHp<=0)
        {
            Destroy(gameObject);
        }
    }
}
