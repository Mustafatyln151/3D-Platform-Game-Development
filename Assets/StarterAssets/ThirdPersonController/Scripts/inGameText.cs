using StarterAssets;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;







public class inGameText : MonoBehaviour
{

    public GameObject playerObject;

    public Transform playerArmature;

    public TextMeshProUGUI topHeightTextObj;

    public float  topHeight;

    
    private void Start()
    {
        
        if (playerObject == null)
        {

            playerObject = GameObject.Find("PlayerObject");


        }

        playerArmature = playerObject.transform.GetChild(1);

        topHeightTextObj = GameObject.Find("LastMostReachedHeight").GetComponent<TextMeshProUGUI>();

        
    }


    private void Update()
    {

        topHeight = playerArmature.GetComponent<ThirdPersonController>().lastReachedMostHeight;

         
        showText();
    
    
    }


    private void showText()
    {

        topHeightTextObj.text = "En Yüksek Nokta: " +  topHeight.ToString("F2") + "m";




    }

















}
