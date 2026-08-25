using UnityEngine;
using UnityEngine.UI;

public class ListStarter : MonoBehaviour, LoopScrollPrefabSource
{
    public LoopVerticalScrollRect loopRect;
    public GameObject myTemplate;

    void Start()
    {
        loopRect.totalCount = 50;
        loopRect.prefabSource = this;
        loopRect.RefillCells();
    }

    public GameObject GetObject(int index)
    {
        return Instantiate(myTemplate);
    }

    public void ReturnObject(Transform go)
    {
        Destroy(go.gameObject);
    }
}