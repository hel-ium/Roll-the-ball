using UnityEngine;
using UnityEngine.UI;

public class Script : MonoBehaviour
{

    public Transform player;
    public Text scoreText;
 
    void Update()
    {
        //updating position in z axis
        scoreText.text = player.position.z.ToString("0");
        
    }
}
