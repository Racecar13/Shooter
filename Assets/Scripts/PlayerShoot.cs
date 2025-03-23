using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    public GameObject prefab;
    public GameObject shootPoint;
    public ParticleSystem muzzleEffect;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnFire(InputValue value)
    {
        if (value.isPressed)
        {
            Instantiate(prefab, shootPoint.transform.position, shootPoint.transform.rotation);
            muzzleEffect.Play();
        }
        
    }
}
