using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperEmplacementController : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> BumperEmplacementListAvailable;

    private List<GameObject> BumperEmplacementListUnavailable = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public GameObject returnRandomFreeEmplacement()
    {
        int rand = Random.Range(0, BumperEmplacementListAvailable.Count - 1);
        GameObject emplacementToReturn = BumperEmplacementListAvailable[rand];
        BumperEmplacementListUnavailable.Add(BumperEmplacementListAvailable[rand]);
        BumperEmplacementListAvailable.RemoveAt(rand);
        Destroy(emplacementToReturn.GetComponent<Emplacements>().BumperType);
        return emplacementToReturn;
    }
}
