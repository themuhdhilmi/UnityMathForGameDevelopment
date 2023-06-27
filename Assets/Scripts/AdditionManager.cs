using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AdditionManager : MonoBehaviour
{
    [SerializeField] Button buttonAdd;
    [SerializeField] Button buttonMinus;
    [SerializeField] Button buttonClear;
    [SerializeField] Transform parabolaStart;
    [SerializeField] GameObject parabolaVisualizerPrefab;
    [SerializeField] TMP_InputField firstInput;
    [SerializeField] TMP_InputField secondInput;

    private List<GameObject> instantiatedParabolaPrefabList;

    // Start is called before the first frame update
    void Start()
    {
        instantiatedParabolaPrefabList = new List<GameObject>();

        buttonAdd.onClick.AddListener(() =>
        {
            int calculate = Int32.Parse(firstInput.text) + Int32.Parse(secondInput.text);
            if (calculate == 0) return;

            GameObject instantiateObject = Instantiate(parabolaVisualizerPrefab, parabolaStart.position, Quaternion.identity);
            ParabolaVisualizer parabolaVisualizer = instantiateObject.GetComponent<ParabolaVisualizer>();

            Vector3 calculatedVector = new Vector3(calculate, 0, 0);

            parabolaVisualizer.DrawParabolaWithLocation(new Vector3(0,0,0), calculatedVector, 5f);

            instantiatedParabolaPrefabList.Add(instantiateObject);
        });

        buttonMinus.onClick.AddListener(() =>
        {
            int calculate = Int32.Parse(firstInput.text) - Int32.Parse(secondInput.text);
            if (calculate == 0) return;

            GameObject instantiateObject = Instantiate(parabolaVisualizerPrefab, parabolaStart.position, Quaternion.identity);
            ParabolaVisualizer parabolaVisualizer = instantiateObject.GetComponent<ParabolaVisualizer>();

            Vector3 calculatedVector = new Vector3(calculate, 0, 0);

            parabolaVisualizer.DrawParabolaWithLocation(new Vector3(0, 0, 0), calculatedVector, 5f);

            instantiatedParabolaPrefabList.Add(instantiateObject);
        });

        buttonClear.onClick.AddListener(() =>
        {
            foreach (var parabolaPrefabs in instantiatedParabolaPrefabList)
            {
                Destroy(parabolaPrefabs);
            }
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
