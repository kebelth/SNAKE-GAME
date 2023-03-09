using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    Transform container;

    [SerializeField]
    GameObject[] fruits;

    [SerializeField]
    float interval = 5.0F;

    [SerializeField]
    float lifeTime = 30.0F;

    [SerializeField]
    Vector3 bottomLeft;

    [SerializeField]
    Vector3 topRight;

    float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= interval)
        {
            timer = 0.0F;

            int index = Random.Range(0, fruits.Length);

            Vector3 position = bottomLeft;
            position.x = Random.Range((int)bottomLeft.x, (int)topRight.x + 1);
            position.z = Random.Range((int)bottomLeft.z, (int)topRight.z + 1);

            GameObject fruit = Instantiate(fruits[index], position, Quaternion.identity, container);

            Destroy(fruit, lifeTime);

        }
    }
}
