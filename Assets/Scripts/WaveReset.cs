/* Name: Liam McDougall
 * Date: 2026/09/22
 */
using System.Threading;
using UnityEngine;

public class WaveReset : MonoBehaviour
{
    Vector2 begin = new Vector2 (0f, 0f);
    GameObject curPosition;
    float position;
    int initTimer = 25; //Number for moving the timer
    int timer = 25; //Will delay moving the waves too fast

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        position = transform.position.y;
  
    }

    // Update is called once per frame
    void Update()
    {
        if (position < -8)
        {
            position = 9;
            transform.position = new Vector3(transform.position.x, position, transform.position.z);
        } /*https://docs.unity3d.com/6000.0/Documentation/ScriptReference/Transform-position.html
           Used this source to change a position
           */
        else if (timer <= 0)
        {
            position = position - 0.1f;
            transform.position = new Vector3(transform.position.x, position, transform.position.z);
            timer = initTimer;
        }
        else { timer -= 1; }
        
    }
}
