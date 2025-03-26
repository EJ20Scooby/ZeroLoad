using System.Collections.Generic;
using UnityEngine;

public class LevelTransition : MonoBehaviour
{
    [SerializeField] List <GameObject> floors;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetPosition(floors[0]);
    }

    // Update is called once per frame
    void Update()
    {
        CheckLevelEnd();
    }

    void CheckLevelEnd()
    {

    }

    void Transition()
    {

    }

    void SetPosition(GameObject floor)
    {
        floor.transform.position = new Vector2(-9f, 0f);
    }

    void SetRotation(int x, int y, int z)
    {

    }
}
