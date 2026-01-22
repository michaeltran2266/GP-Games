using UnityEngine;
using UnityEngine.UIElements;

public class InterpolationDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform player;
    public float speed = 5f;

    void Start()
    {
        if(!player)
        {
            player = GameObject.FindGameObjectWithTag("Player").transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        float step = Time.deltaTime * speed;
        // transform.position = Vector3.Lerp(transform.position, player.position, step);
        transform.position = Vector3.MoveTowards(transform.position, player.position, step);
    }
}
