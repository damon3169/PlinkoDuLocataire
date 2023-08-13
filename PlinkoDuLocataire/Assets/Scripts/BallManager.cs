using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallManager : MonoBehaviour
{

    public int numberOfBalls = 1;
    [SerializeField]
    private ShopManager shopManager;
    public GameObject ball;
    public float maxHorizontal;
    public float maxVertical;
    public float minVertical;
    // Start is called before the first frame update
    void Start()
    {
        shopManager = GameObject.FindGameObjectWithTag("ShopManager").GetComponent<ShopManager>();
        spawnBall();
    }

    // Update is called once per frame
    void Update()
    {
        if (numberOfBalls <= 0)
        {
            shopManager.DisplayShop();
            numberOfBalls+=1;
        }
    }

    public void removeBall()
    {
        numberOfBalls -= 1;
    }

    public void spawnBall()
    {
        for(int i = 0; i < numberOfBalls; i++){
            Vector3 randPos = new Vector3(Random.Range(-20, maxHorizontal), Random.Range(minVertical, maxVertical), 0);
            Instantiate(ball, randPos, Quaternion.identity);
        }
    }
}
