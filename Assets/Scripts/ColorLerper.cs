using UnityEngine;

public class ColorLerper : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Color initialColor = Color.red;
    public Color targetColor = Color.green;
    
    private Renderer renderer;
   
    void Start()
    {
        renderer = GetComponent<Renderer>();
        renderer.material.color = Color.red;
        Debug.Log(renderer.material.color);
    }

    // Update is called once per frame
    void Update()
    {
        // renderer.material.color = Color.red;
        float step = Mathf.PingPong(Time.time, 1);

        renderer.material.color = Color.Lerp(initialColor, targetColor, step);
    }
}
