using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatesCounter : BaseCounter
{

    public event EventHandler OnPlateSpawned;


    [SerializeField] private KitchenObjectSO plateKitchenObjectSO;

    private float spwanPlateTimer;
    private float spwanPlateTimerMax = 4f;
    private int plateSpawnedAmount;
    private int plateSpwanAmountMax = 4;

    private void Update()
    {
        spwanPlateTimer +=Time.deltaTime;
        if  (spwanPlateTimer > spwanPlateTimerMax)
        {
            spwanPlateTimer = 0f;

            if(plateSpawnedAmount < plateSpwanAmountMax)
            {
                plateSpawnedAmount ++ ;

                OnPlateSpawned?.Invoke(this, EventArgs.Empty);
            }
        }
        
    }
}
