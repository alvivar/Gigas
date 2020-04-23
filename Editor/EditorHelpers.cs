using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class EditorHelpers : Editor
{
    [MenuItem("Tools / Grid Data")]
    public static void InitGridData()
    {
        if (!Selection.activeTransform)
        {
            Debug.LogError("You need to select objects");
            return;
        }

        foreach (Transform t in Selection.transforms)
        {

            List<GridData> children = new List<GridData>();
            GetAllChildren(t, ref children);

            foreach (GridData child in children)
            {
                child.InitData();
            }

            //EditorUtility.SetDirty(target);

            Debug.Log("Recorded!");
        }
    }

    public static void GetAllChildren(Transform parent, ref List<GridData> transforms)
    {

        GridData data = parent.GetComponent<GridData>();
        if (data != null)
            transforms.Add(data);

        foreach (Transform t in parent)
        {
            data = t.GetComponent<GridData>();
            if (data != null)
                transforms.Add(data);

            GetAllChildren(t, ref transforms);
        }
    }
}
