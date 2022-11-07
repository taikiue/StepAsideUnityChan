using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroy : MonoBehaviour
{
    //Unityちゃんのオブジェクト
    private GameObject unitychan;
    
    
    // Start is called before the first frame update
    void Start()
    {
        //unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");
    }

    // Update is called once per frame
    void Update()
    {
       
          if(unitychan.transform.position.z - transform.position.z >6f)
            {
                Destroy(gameObject);
            }
        
           
        
        
       
    }
}
