using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.Rendering.DebugUI;

public class PlayerShoot : MonoBehaviour
{
    public GameObject prefab;
    public GameObject shootPoint;
    public ParticleSystem muzzleEffect;
    public AudioSource shootSound;
    public float fireRate;
    public int bulletsAmount;
    public Animator animator;

    public void OnFire(InputValue value)
    {
        animator.SetBool("Shooting", value.isPressed);

        if (value.isPressed)
        {
            InvokeRepeating("Shoot", 3 * fireRate, fireRate);
        }
        else
        {
            CancelInvoke();
        }
    }

    public void Shoot()
    {
        if (bulletsAmount > 0 && Time.timeScale > 0)
        {
            bulletsAmount--;
            Instantiate(prefab, shootPoint.transform.position, shootPoint.transform.rotation);
            muzzleEffect.Play();
            shootSound.Play();
        }
    }
}
