using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject prefab;
    public GameObject shootPoint;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnFire()
    {
        Instantiate(prefab, shootPoint.transform.position, shootPoint.transform.rotation);
    }
}
