using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject platform;


    // Update is called once per frame
    void Update()
    {
        float posx = Random.Range(transform.position.x + 4, transform.position.x + 7);
        float posy = Random.Range(transform.position.y - 3, transform.position.y + 4);
        transform.position = new Vector2(posx, posy);
        Instantiate(platform, transform.position, transform.rotation);
    }
}
