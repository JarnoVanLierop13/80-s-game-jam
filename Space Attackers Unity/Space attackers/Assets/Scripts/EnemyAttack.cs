using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public Rigidbody2D EnemyLaser;
    public Transform LaserOrigin;
    private bool CanShoot = false;


    private void Update()
    {
        StartCoroutine(Delay());
        EnemyShoot();
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(3.0f);
        CanShoot = true;
    }

    void EnemyShoot()
    {
        if (CanShoot == true)
        {
            Instantiate(EnemyLaser, LaserOrigin.position, LaserOrigin.rotation);
            CanShoot = false;
        }
    }

}
