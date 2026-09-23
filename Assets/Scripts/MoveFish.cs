using UnityEngine;
using UnityEngine.UIElements;

public class MoveFish : MonoBehaviour
{
    int xPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        xPos = Random.Range(-10, 10);
        /* Used to figure out random int generator
         https://discussions.unity.com/t/how-do-you-generate-multiple-unique-random-numbers-within-a-range-based-on-a-seed/813803
         */


    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > -6)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.02f, transform.position.z);
        } 
        else if (transform.position.y <= -6)
        {
            Destroy(gameObject);
        }
    }
}
