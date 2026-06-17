using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hudcontroller : MonoBehaviour
{
    public static hudcontroller  Instance;

    public Image HpBar;

    void Awake() 
    {
        Instance = this;



    }



    private void Update()
    {
    }

     

    public void updateHp (int hp)
    {
        HpBar.fillAmount = hp / 100f;
    }


}






    


