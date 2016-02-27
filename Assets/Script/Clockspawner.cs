using UnityEngine;
using System.Collections;

public class Clockspawner : MonoBehaviour {
	public GameObject clock; //敵のオブジェクト
	public float interval = 60; //何秒に一回敵を発生させるか
	float timer = 0; //タイマー
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime; //タイマーを減らす
		if (timer < 0) { //タイマーがゼロより小さくなったら
			Spawn (); // Spawnメソッドを呼ぶ
			timer = interval; // タイマーをリセットする
		}
	}

	// 敵を生成するメソッド
	void Spawn(){
		Instantiate (clock, transform.position, transform.rotation);
	}
}