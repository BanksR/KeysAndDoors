using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyChain : MonoBehaviour 
{
    //Initialise a new List of Key called keys
    public List<Key> keys = new List<Key>();


    //This public function will be called from other classes
    public void AddKey (Key keyToAdd)
    {
        keys.Add(keyToAdd);
    }

    //This function removes a key if necassary
    public void RemoveKey (Key keyToRemove)
    {
        keys.Remove(keyToRemove);
    }





}
