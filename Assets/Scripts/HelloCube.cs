using UnityEngine;

public class HelloCube : MonoBehaviour
{
    public float rotationAmount = 5.0f;
    public float translationAmount = 1.0f;

    [SerializeField] 
    private int health;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Debug.Log("Hello, Cube!");
        // transform.Rotate(0, 5, 0);
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Hello!");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Rotate(0, rotationAmount, 0);
        }

        if(Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(0, 0 , translationAmount);
        }
    }

    private void OnMouseDown()
    {
        Debug.Log("Cube clicked");
        // gameObject references the game object the script is attached to
        // Destroy(gameObject);
        
        gameObject.SetActive(false);
    }
}
