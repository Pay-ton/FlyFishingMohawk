/* Name: Liam McDougall
 * Date: 2026/09/22
 */
using UnityEngine;

public class MoveBoat : MonoBehaviour
{
    //Variables
    float speed = 5f;

    // Update is called once per frame
    void Update()
    {
        // Horizontal Movement
        float movementX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        Vector3 position = transform.position;
        position.x += movementX;
        transform.position = position;
    }
}
