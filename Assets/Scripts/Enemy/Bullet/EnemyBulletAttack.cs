using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletAttack : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform[] ateşNoktaları;

    private float bulletSpeed = 0.5f;
    float bulleLife = 2f;
    private float timeForFire = 1f;
 
    
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("EnemyAttack", 0f, timeForFire);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void EnemyAttack()
    {
        Transform randomFirePoint = ateşNoktaları[Random.Range(0, ateşNoktaları.Length)];
        
        GameObject bullet = Instantiate(bulletPrefab, randomFirePoint.position, Quaternion.identity);
        
        
        Rigidbody2D mermiRigidbody = bullet.GetComponent<Rigidbody2D>();
        mermiRigidbody.velocity = new Vector2(0, - randomFirePoint.position.y)* bulletSpeed * Time.deltaTime;
        

        // Mermiye hız atayarak ileri doğru hareket etmesini sağla
        
        Destroy(bullet, bulleLife);
    }

}
