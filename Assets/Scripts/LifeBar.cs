using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeBar : MonoBehaviour
{
    Image image;
    public Life targetLife;
    float maximumLife;

    private void Awake()
    {
        image = GetComponent<Image>();
        maximumLife = targetLife.amount;
    }

    private void Update()
    {
        image.fillAmount = targetLife.amount / maximumLife;
    }
}
