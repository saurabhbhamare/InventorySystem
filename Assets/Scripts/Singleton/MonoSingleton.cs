using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoSingleton : MonoBehaviour
{
    public  static MonoSingleton instance; 

    private void Awake()
    {
        if(instance == null )
        {
            instance = this;
            Debug.Log("  for   " +  gameObject.name  + " instance is not null ");
        }
        else
        {
            Destroy(this);
            Debug.Log("  for  " + gameObject.name + " instance is null ");
        }
    }
    
}
public class Game : MonoSingleton
{
    public void PlayGame()
    {

    }
}
public class World : MonoBehaviour
{

    private void Awake()
    {
    //    Game.instance.PlayGame();
    }
}


