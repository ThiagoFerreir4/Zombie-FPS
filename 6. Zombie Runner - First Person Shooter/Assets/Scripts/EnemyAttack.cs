using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float damage = 40f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void AttackHitEvent()
    {
        if (target == null) return;
        Debug.Log("bang bang");
    }
}
