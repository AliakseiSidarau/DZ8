using UnityEngine;

public class NinjaControl : MonoBehaviour
{
    SpriteRenderer ninja;
    
    void Start()
    {
        ninja = GetComponent<SpriteRenderer>();        
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.touchCount > 0)
        {
           ninja.flipX = !ninja.flipX;
        }        
    }
}