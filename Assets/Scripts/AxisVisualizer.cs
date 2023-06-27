using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisVisualizer : MonoBehaviour
{
    [SerializeField] int lineXLength;
    [SerializeField] int lineYLength;
    [SerializeField] int lineZLength;

    [SerializeField] LineRenderer lineX;
    [SerializeField] LineRenderer lineY;
    [SerializeField] LineRenderer lineZ;

    private void Start()
    {
        Vector3[] lineXVector = new Vector3[] { new Vector3(lineXLength, 0 , 0) , new Vector3(-lineXLength, 0, 0) };
        Vector3[] lineYVector = new Vector3[] { new Vector3(0, lineYLength, 0), new Vector3(0, -lineYLength, 0) };
        Vector3[] lineZVector = new Vector3[] { new Vector3(0, 0, lineZLength), new Vector3(0, 0, -lineZLength) };

        lineX.SetPositions(lineXVector);
        lineY.SetPositions(lineYVector);
        lineZ.SetPositions(lineZVector);
    }
}
