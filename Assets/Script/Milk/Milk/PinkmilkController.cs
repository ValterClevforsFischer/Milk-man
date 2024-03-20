using UnityEngine;

public class PinkmilkController : MonoBehaviour
{
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(gameObject);
           
        }
    }
}
