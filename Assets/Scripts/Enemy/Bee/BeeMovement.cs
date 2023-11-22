using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeMovement : MonoBehaviour
{
    public GameObject bee;
    public Transform[] startPosition;
    public Transform[]finishPosition;
    private Transform currentFinishPosition;
    float speed = 0.5f;
    GameObject bees;
    private int currentIndex = 0;

// Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBee", 0, 3f);
        
    }

// Update is called once per frame
    void Update()
    {
        MoveBee();
        
    }

    void SpawnBee()
    {
        
            // Başlangıç pozisyonunu seç
            Transform sp = startPosition[currentIndex];

            // Bitiş pozisyonunu seç
            currentFinishPosition = finishPosition[currentIndex];

            // Arıyı oluştur ve başlangıç pozisyonuna yerleştir
            bees = Instantiate(bee, sp.position, Quaternion.identity);

            currentIndex++;

            if (currentIndex >= 3)
            {
                currentIndex = 0;
            }
            
    }

    void MoveBee()
    {
        if (bees != null)
        {
            // Arıyı doğrudan hedefe hareket ettir
            bees.transform.position = Vector2.MoveTowards(bees.transform.position, currentFinishPosition.position, speed * Time.deltaTime);

            // Hedefe ulaşıldığında
            if (Vector2.Distance(bees.transform.position, currentFinishPosition.position) < 0.1f)
            {
                // Arı objesini yok et
                Destroy(bees);
            }
        }
    }
}
