using UnityEngine;

public class MathDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Vector3 position;
    private Vector3 direction;
    
    void Start()
    {
        Vector3 up = Vector3.up; // (0, 1, 0)
        Vector3 down = Vector3.down; // (0, -1, 0)

        var forward = Vector3.forward;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // transform.Rotate(0, 1, 0);
            transform.Rotate(Vector3.up * 90);
        }

        transform.Rotate(Vector3.up * 90 * Time.deltaTime);
    }
}
