using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControl : MonoBehaviour
{
    private Animator _anims;
    public Collider _doorCollider;

    public int DoorID = 0;

    private void Awake()
    {
        _anims = GetComponent<Animator>();
    }


    // Upon a trigger, if zombie let it pass.
    // If Player do the OpenDoor Function.
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Zombie"))
        {
            _anims.SetTrigger("Open");
            _doorCollider.enabled = false;
        }

        if (other.gameObject.CompareTag("Player"))
        {
            KeyChain keysInInventory = other.GetComponent<KeyChain>();
            OpenDoor(keysInInventory);
        }
    }

    
    // This function will loop through every key in the players
    // KeyChain List of Keys. If it finds a key that matches the DoorID,
    // it will open the door.
    public void OpenDoor(KeyChain keysToCheck)
    {
        foreach (var key in keysToCheck.keys)
        {
            if (key.keyID == DoorID)
            {
                _anims.SetTrigger("Open");
                keysToCheck.RemoveKey(key);
                _doorCollider.enabled = false;
                return;
            }
        }
        
        Debug.Log("Door Remains Locked - find the correct Key!");
    }
}
