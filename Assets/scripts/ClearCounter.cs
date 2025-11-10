using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : MonoBehaviour
{
    [SerializeField]private KitchenObjectSO  kitchenObjectSO;
    [SerializeField] private Transform CounterTopPoint;
    public void Interact()
    {
        Debug.Log("interact!");
        Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab, CounterTopPoint);
        kitchenObjectTransform.localPosition = Vector3.zero;
    }   
}