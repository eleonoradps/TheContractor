using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainerActivator : MonoBehaviour
{
    [SerializeField] private GameObject sellerContainer;
    [SerializeField] private GameObject storeContainer;
    [SerializeField] private GameObject manufacturerContainer;

    private bool isSellerContainerActive = false;
    private bool isStoreContainerActive = false;
    private bool isManufacturerContainerActive = false;

    public void ActivateSellerContainer()
    {
        isSellerContainerActive = !isSellerContainerActive;
        sellerContainer.SetActive(isSellerContainerActive);
    }

    public void ActivateStoreContainer()
    {
        isStoreContainerActive = !isStoreContainerActive;
        storeContainer.SetActive(isStoreContainerActive);
    }
    public void ActivateManufacturerContainer()
    {
        isManufacturerContainerActive = !isManufacturerContainerActive;
        manufacturerContainer.SetActive(isManufacturerContainerActive);
    }
}
