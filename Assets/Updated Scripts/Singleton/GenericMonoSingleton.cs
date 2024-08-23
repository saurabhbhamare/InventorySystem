using UnityEngine;
using System;
public class GenericMonoSingleton<T> : MonoBehaviour where T : GenericMonoSingleton<T>
{
    public static T Instance { get { return instance; } }
    private static T instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = (T)this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }   
}
