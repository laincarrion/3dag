using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //collision detection
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        //check if player hits an object with door tag
        if (hit.gameObject.CompareTag("house Door"))
        {
            print("Player hit a door!");
            // Handle collision with door
        }
    }

}
