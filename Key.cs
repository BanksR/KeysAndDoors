using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public int keyID;
    public string keyName;
    private KeyChain keyChain;

	private void OnTriggerEnter(Collider other)
	{
        if(other.gameObject.CompareTag("Player"))
        {

	        keyChain = other.GetComponent<KeyChain>();
            // Add this Key to our KeyChain
            // Play a pick-up SFX
            keyChain.AddKey(this);
	        Debug.Log("You picked up the "+keyName+ ". and add it to your Keychain");

            this.gameObject.SetActive(false);
        }
	}
}
