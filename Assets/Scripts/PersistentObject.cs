using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentObject : MonoBehaviour
{
    public string nameVal;
    public static PersistentObject instance { get; private set;  }
    private void Awake()
    {
        if (instance != null)
        {
            Debug.Log("Found more than one Persistent Object in the scene. Destroying the newest one.");
            Destroy(this.gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }
}
