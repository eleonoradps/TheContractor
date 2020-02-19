using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CounterManager : MonoBehaviour
{
    [SerializeField] private int money;
    [SerializeField] private TextMeshProUGUI textMoneyCounter;

    [SerializeField] private int stock;
    [SerializeField] private TextMeshProUGUI textStockCounter;

    [SerializeField] private int merchandise;
    [SerializeField] private TextMeshProUGUI textMerchCounter;
    
    public void AddMoney(int value)
    {
        money += value;
        textMoneyCounter.text = money.ToString();
    }

    public void AddStock(int value)
    {
        stock += value;
        textStockCounter.text = stock.ToString();
    }

    public void AddMerch(int value)
    {
        merchandise += value;
        textMerchCounter.text = merchandise.ToString();
    }
}
