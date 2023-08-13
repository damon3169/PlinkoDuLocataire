using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ShopEmplacement : MonoBehaviour
{
    private GameObject bumperType;
    public TMP_Text bumperName;
    public TMP_Text bumperDescription;
    public Image bumperImage;
    private ShopManager shopManager;
    public BallManager ballManager;

    public void Start()
    {
        shopManager = GameObject.FindGameObjectWithTag("ShopManager").GetComponent<ShopManager>();
    }

    public void SetBumper(GameObject bumperType)
    {
        this.bumperType = bumperType;
        bumperName.text = bumperType.name;
        bumperDescription.text = bumperType.GetComponent<BumperType>().descriptionBumper;
        bumperImage.sprite = bumperType.GetComponent<BumperType>().spriteBumper.sprite;
        bumperImage.color = bumperType.GetComponent<BumperType>().spriteBumper.color;
    
    }

    public void onClickSelect()
    {
        shopManager.CreateBumperAtRandomEmplacement(bumperType);
        shopManager.CloseShop();
        ballManager.spawnBall();
    }

}
