using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour
{
    public int keyRequired = 1;
    public Text DoorUI;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            int playerKeys = other.GetComponent<Player>().GetKeys();
            if (playerKeys >= keyRequired)
            {
                DoorUI.text = "Win!";
            }
            else
            {
                DoorUI.text = "Door\nis\nclosed!";
            }
            DoorUI.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        DoorUI.gameObject.SetActive(false);
    }
}
