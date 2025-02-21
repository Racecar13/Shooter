using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WavesManager : MonoBehaviour
{
    public static WavesManager instance;
    
    public List<Wave> waves;
    public UnityEvent onChanged;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.LogError("Duplicated WavesManager, ignoring this one", gameObject);
        }
    }

    public void AddWave(Wave wave)
    {
        waves.Add(wave);
        onChanged.Invoke();
    }

    public void RemoveWave(Wave wave)
    {
        waves.Remove(wave);
        onChanged.Invoke();
    }
}
