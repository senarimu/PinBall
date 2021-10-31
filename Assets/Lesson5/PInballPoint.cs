using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PInballPoint : MonoBehaviour
{
    
    private GameObject pointText;

    int scorePoint = 0;



    // Start is called before the first frame update
    void Start()
    {
        this.pointText = GameObject.Find("Point");
    }


    // Update is called once per frame
    void Update()
    {
        
    }


    void OnCollisionEnter(Collision other)
    {
        
        if (other.gameObject.tag == "SmallStarTag" )
        {
            Debug.Log(scorePoint += 20);
        }
         else if (other.gameObject.tag == "LargeStarTag")
        {
            Debug.Log(scorePoint += 10);
        }
        else if (other.gameObject.tag == "SmallCloudTag")
        {
            Debug.Log(scorePoint += 20);
        }
        else if (other.gameObject.tag == "LargeCloudTag")
        {
            Debug.Log(scorePoint += 10);
        }
        this.pointText.GetComponent<Text>().text = "point"
                 + scorePoint.ToString();

    }
    

    }


    

