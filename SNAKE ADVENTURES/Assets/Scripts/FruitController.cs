using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitController : MonoBehaviour
{
    [SerializeField]
    float points = 3;

    float minusPoints = -1; 
    
    float timer = 0;

    bool timeReached=false;

    void Update()
    {
        if (!timeReached)
        {
            timer += Time.deltaTime;
        }
        if (timer > 9.8 && !timeReached)
        {
            timeReached = true;
            ExtractPoints();
        }
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SnakeController controller = other.GetComponent<SnakeController>();
            controller.IncreasePoints(points);
            Destroy(gameObject);
        }
    }
    void ExtractPoints()
    {
        GameObject jugador = GameObject.FindGameObjectWithTag("Player");
        SnakeController controller = jugador.GetComponent<SnakeController>();
        controller.IncreasePoints(minusPoints);
    }
    
}
