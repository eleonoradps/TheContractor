using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CooldownBar3 : MonoBehaviour
{
    Image cooldownBar;
    [SerializeField] float maxTime;
    float currentTime;
    [SerializeField] float increasementPerSecond;
    const float restartTime = 0;
    [SerializeField]
    GameObject counterManager;
    [SerializeField]
    GameObject counterManager2;
    
    
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
            counterManager.GetComponent<CounterManager>().AddMerch(15);
            counterManager2.GetComponent<CounterManager>().AddMoney(-10);
            currentTime = restartTime;
            this.transform.parent.gameObject.SetActive(false);
        }
    }
}
