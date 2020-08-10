using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    static AudioScript instance = null;

    public void Awake()
    {
        if (instance !=null)
        {
            Destroy(transform.gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(transform.gameObject);
        }
    }
}
