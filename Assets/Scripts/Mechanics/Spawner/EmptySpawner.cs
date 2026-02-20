using UnityEngine;

public class EmptySpawner : MonoBehaviour
{
    public GameObject Spawn(GameObject prefab, Vector3 position)
    {
        GameObject gObj = Instantiate(prefab, position, Quaternion.identity);

        return gObj;
    }
}
