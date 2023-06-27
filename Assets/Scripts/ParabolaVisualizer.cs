using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParabolaVisualizer : MonoBehaviour
{
    public int numberOfPoints = 100;
    [SerializeField] LineRenderer lineRenderer;

    public void DrawParabola(Vector3 startPoint, Vector3 endPoint, float height)
    {
        // Calculate the midpoint between the start and end points
        Vector3 midPoint = (startPoint + endPoint) / 2f;

        // Calculate the distance between the start and end points
        float distance = Vector3.Distance(startPoint, endPoint);

        // Initialize an array to store the points of the parabola
        Vector3[] points = new Vector3[numberOfPoints];

        for (int i = 0; i < numberOfPoints; i++)
        {
            // Calculate the t value, ranging from 0 to 1, based on the current iteration
            float t = i / (float)(numberOfPoints - 1);

            // Calculate the x position of the point on the parabola
            float x = Mathf.Lerp(startPoint.x, endPoint.x, t);

            // Calculate the y position of the point on the parabola
            float y = Mathf.Lerp(startPoint.y, endPoint.y, t) + (height + (distance * 0.5f) ) * 4f * t * (1f - t);

            // Calculate the z position of the point on the parabola
            float z = Mathf.Lerp(startPoint.z, endPoint.z, t);

            // Set the current point in the array
            points[i] = new Vector3(x, y, z);
        }

        // Set the positions of the line renderer to the calculated points
        lineRenderer.positionCount = numberOfPoints;
        lineRenderer.SetPositions(points);
    }
}
