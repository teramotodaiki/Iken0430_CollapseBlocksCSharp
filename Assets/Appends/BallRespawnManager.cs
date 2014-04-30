using UnityEngine;
using System.Collections;

/// <summary>
/// 消滅したボールをリスポーン（復活）させる
/// </summary>
[AddComponentMenu("C#/Ball Respawn Manager")]
public class BallRespawnManager : MonoBehaviour {

    /// <summary>
    /// 使いたいボールのプレハブ
    /// </summary>
    public GameObject BallPrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    /// <summary>
    /// ボールを復活させる。この処理は、Destroyされた時、BottomWallControllerから呼び出す。
    /// </summary>
    public void Respawn()
    {

        // 新しくオブジェクトを生成する ボールプレハブをもとに、このオブジェクトの位置に
        GameObject ball = (GameObject)Instantiate(BallPrefab, transform.position, Quaternion.identity);

        // 生成されたボールを、ラケットに追従させる（発射されるまで）
        ball.transform.parent = transform.parent; // parent ... (親) ... ここでは、追従関係を意味する。transform.parentがラケットを表し、ボールがラケットに追従すると指定する。
    }
}
