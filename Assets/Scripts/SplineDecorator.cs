using System;
using UnityEngine;

public class SplineDecorator : MonoBehaviour
{
    public BezierSpline spline;
    public int frequency;
    public bool lookForward;
    public Transform[] items;
    public UnityEngine.Object[] decorations;

    public void CreateDecoration()
    {
        if(frequency <= 0  || items == null ||items.Length == 0)
        {
            return;
        }
        float stepSize = frequency * items.Length;
        decorations = new UnityEngine.Object[(int)stepSize];
        if(spline.Loop || stepSize == 1)
        {
            stepSize = 1f / stepSize;
        }
        else
        {
            stepSize = 1f / (stepSize - 1);
        }
        GameObject parent = new GameObject("Dominoes");
        parent.transform.parent = transform;
        for (int p = 0, f = 0; f < frequency; f++)
        {
            for(int i = 0; i < items.Length; i++, p++)
            {

                Transform item = Instantiate(items[i], parent.transform) as Transform;
                item.parent = parent.transform;
                Vector3 position = spline.GetPoint(p * stepSize);
                item.position = position;
                if (lookForward)
                {
                    item.transform.LookAt(position + spline.GetDirection(p * stepSize));
                }
                parent.transform.rotation = Quaternion.identity;
                UnityEngine.Object o = item.gameObject;
                decorations[(f * items.Length) + i] = o;
            }
        }
    }

    public void DeleteDecorations()
    {
        Array.Clear(decorations, 0, decorations.Length);
    }
}
