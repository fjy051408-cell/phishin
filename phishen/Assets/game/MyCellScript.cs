using UnityEngine;
public class MyCellScript : MonoBehaviour
{
    void ScrollCellIndex(int idx)
    {
        // 这一步是让格子把自己的名字改成它是第几个，方便你看到效果
        gameObject.name = "我是第 " + idx + " 个格子";
    }
}