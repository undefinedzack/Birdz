using UnityEngine;

public class Birdie : MonoBehaviour
{
    private void OnMouseDown(){

        GetComponent<SpriteRenderer>().color = Color.red; 
    }

    private void OnMouseUp(){

        GetComponent<SpriteRenderer>().color = Color.white;
    }

    private void OnMouseDrag(){
        
        Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position= new Vector3(newPosition.x , newPosition.y);
    }
}
