using UnityEngine;

public class letsbang : MonoBehaviour
{

    public playermovement movement;

   void OnCollisionEnter(Collision collisionInfo)
    {
        //we  check if the object we collided with
       if(collisionInfo.collider.tag  == "Obstacles")
        {
            movement.enabled = false;
        }
    }
}
