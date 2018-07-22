using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallController : MonoBehaviour {

    //ボールが見える可能性のあるz軸の最大値
    private float visiblePosZ = -6.5f;

    //ゲームオーバを表示するテキスト
    private GameObject gameoverText;

    //スコアを表示するテキスト
    private GameObject scoreText;


    //得点
    private int score = 0;


    // Use this for initialization
    void Start() {
        //シーン中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("｝GameOverText");

        //シーン中のscoreTextオブジェクトを取得
        this.scoreText = GameObject.Find("ScoreText");

        //シーン中のgameoverTextオブジェクトを取得（追加）
        this.gameoverText = GameObject.Find("GameOverText");

    }


    // Update is called once per frame
    void Update() {
        //ボールが画面外に出た場合
        if (this.transform.position.z < this.visiblePosZ) {
            //GameoverTextにゲームオーバを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }


    }
    //衝突時に呼ばれる関数（追加）
    void OnCollisionEnter(Collision other) {

        //オブジェクトに衝突した場合
        if (other.gameObject.tag == "SmallCloudTag") {

            // スコアを加算
            this.score += 10;

        

    } else if(other.gameObject.tag == "LargeCloudTag") {

            // スコアを加算
            this.score += 30;

        

  } else if (other.gameObject.tag == "LargeStarTag") {

            // スコアを加算
            this.score += 20;

        
}

        //ScoreText獲得した点数を表示
        this.scoreText.GetComponent<Text>().text = "Score " + this.score + "pt";

    }


       


    }

    



    




