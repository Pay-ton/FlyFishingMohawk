/* Name: Liam McDougall
 * Date: 2026/09/22
 */
using UnityEngine;
using UnityEngine.UIElements;

public class MoveBoat : MonoBehaviour
{
    //Variables
    float position;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        position = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            position = position - 0.5f;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            position = position + 0.5f;
        }
        transform.position = new Vector3(position, transform.position.y, transform.position.z);
    }
}
