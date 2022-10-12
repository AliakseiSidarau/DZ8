using UnityEngine;

public class Parallax2 : MonoBehaviour
{
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] float moveSpeed = 2f;
    [SerializeField] float parallaxEffect = 1f;
    float backGroundSize = 9.2f;
    Vector2 startPosition;
    float newXPosition;
    float backGroundDirection;
    float values;
        
    void Start()
    {
        startPosition = transform.position;
        values = moveSpeed * (1 - parallaxEffect);
    }
        
    void Update()
    {      
        backGroundDirection = spriteRenderer.flipX ? 1f : -1f;
        newXPosition = Mathf.Repeat(Time.time * backGroundDirection * values, backGroundSize);
        transform.position = startPosition + Vector2.right * newXPosition;
    }
}
