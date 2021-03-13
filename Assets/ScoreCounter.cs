using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    //得点を表示するテキスト
    private GameObject scoreText;
    //スコア計算用変数
    private int score = 0;


    // Start is called before the first frame update
    void Start()
    {
        //シーン中のScoreTextオブジェクトを取得
        this.scoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
        //ScoreTextに得点を表示
        this.scoreText.GetComponent<Text>().text = score.ToString();
    }


    //衝突時に呼ばれる関数
    void OnCollisionEnter(Collision collision)
    {
        //Ballが接触したオブジェクトがスモールスターだった場合
        if (collision.gameObject.tag == "SmallStarTag")
        {
            //得点が10点加算される
            score += 10;
        }

        else if(collision.gameObject.tag == "LargeStarTag")
        {
            score += 20;
        }

        else if(collision.gameObject.tag == "SmallCloudTag")
        {
            score += 50;
        }

        else if (collision.gameObject.tag == "LargeCloudTag")
        {
            score += 10000;
        }

    }

}
