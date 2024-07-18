using UnityEngine;

public static class Transforms
{

    public static void DestroyChild(this Transform t, bool destroyImmediate = false)
    {
        foreach (Transform child in t)
        {
            if (destroyImmediate)
                MonoBehaviour.DestroyImmediate(child);
            else
                MonoBehaviour.Destroy(child);
        }
    }

}
