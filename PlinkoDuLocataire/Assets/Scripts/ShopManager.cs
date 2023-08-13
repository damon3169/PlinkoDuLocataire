using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    [SerializeField]
    private BumperEmplacementController BumperEmplacements;

    [SerializeField]
    private List<GameObject> BumperListCommun;
     [SerializeField]
    private List<ShopEmplacement> ShopEmplacements;


    public void CreateBumperAtRandomEmplacement(GameObject Bumper)
    {
        GameObject tempBumperEmplacement = BumperEmplacements.returnRandomFreeEmplacement();
        GameObject newBumper = Instantiate(Bumper, Vector3.zero, Quaternion.identity, tempBumperEmplacement.transform);
        newBumper.transform.localPosition = Vector3.zero;
        Debug.Log(Bumper.transform.localRotation.z);
        newBumper.transform.rotation= Quaternion.Euler(new Vector3(Bumper.transform.rotation.x,Bumper.transform.rotation.y,Bumper.transform.rotation.z));
        tempBumperEmplacement.GetComponent<Emplacements>().BumperType = newBumper;
    }

    public void DisplayShop()
    {
        int randBumperNumber;
        foreach (ShopEmplacement shopEmplacement in ShopEmplacements){
            shopEmplacement.gameObject.SetActive(true);
            randBumperNumber = Random.Range(0, BumperListCommun.Count);
            shopEmplacement.SetBumper(BumperListCommun[randBumperNumber]);
        }
    }

    public void CloseShop()
    {
        foreach (ShopEmplacement shopEmplacement in ShopEmplacements){
            shopEmplacement.gameObject.SetActive(false);
        }
    }


}
