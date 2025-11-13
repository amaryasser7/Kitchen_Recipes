using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : MonoBehaviour, IKitchenObjectParent
{
    [SerializeField] private KitchenObjectSO  kitchenObjectSO;
    [SerializeField] private Transform CounterTopPoint;

    private KitchenObject kitchenObject;

    public void Interact(Player player)
    {
        if  (kitchenObject == null)
        {
        Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab, CounterTopPoint);
        kitchenObjectTransform.GetComponent<KitchenObject>().SetKitchenObjectParent(this);
        kitchenObjectTransform.localPosition = Vector3.zero;
        
        } else
        {
            kitchenObject.SetKitchenObjectParent(player);
        }
    }

    public Transform GetKitchenObjectFollowTransform()
    {
        return CounterTopPoint;
    }


    public void SetKitchenObject (KitchenObject kitchenObject)
    {
        this.kitchenObject = kitchenObject;
    }

    public KitchenObject GetKitchenObject()
    {
        return kitchenObject;
    }


    public void clearkitchenObject()
    {
        kitchenObject = null;
    }

    public bool HasKitchenObject()
    {
        return kitchenObject != null;
    }
}