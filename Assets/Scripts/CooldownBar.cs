using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CooldownBar : MonoBehaviour
{
    Image cooldownBar;
    [SerializeField] float maxTime;
    float currentTime;
    [SerializeField] float increasementPerSecond;
    const float restartTime = 0;
    
    
    void Start()
    {
        cooldownBar = GetComponent<Image>();
        currentTime = restartTime;
    }

    
    void Update()
    {
        if (currentTime < maxTime)
        {
            currentTime += Time.deltaTime * increasementPerSecond;
            cooldownBar.fillAmount = currentTime / maxTime;
        }

        else
        {
            currentTime = restartTime;
            this.transform.parent.gameObject.SetActive(false);
        }
    }
}