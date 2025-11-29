using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateCouunterVisual : MonoBehaviour
{
    [SerializeField] private PlatesCounter platesCounter;
    [SerializeField] private Transform counterTopPoint;
    [SerializeField] private Transform plateVisualPrefab;

    private List<GameObject> plateVisualGameObjectList;


    private void Awake()
    {
        plateVisualGameObjectList = new List<GameObject>();
    }


    private void Start()
    {
        platesCounter.OnPlateSpawned += PlatesCounter_OnPlatesSpawned;
    }

    private void PlatesCounter_OnPlatesSpawned(object sender, System.EventArgs e)
    {
        Transform plateVisualTransform = Instantiate(plateVisualPrefab, counterTopPoint);

        float plateOffSetY = .1f;

        plateVisualTransform.localPosition = new Vector3(0, plateOffSetY * plateVisualGameObjectList.Count , 0);
        plateVisualGameObjectList.Add(plateVisualTransform.gameObject);
    }
}
