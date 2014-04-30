using UnityEngine;
using System.Collections;

/// <summary>
/// 枠の一番下の壁にボールが衝突したとき、ボールを消滅させる
/// </summary>
[RequireComponent(typeof(Collider))]
[AddComponentMenu("C#/Bottom Wall Controller")]
public class BottomWallController : MonoBehaviour {

    /// <summary>
    /// ボールをリスポーン（復活）させるためのマネージャー
    /// </summary>
    private BallRespawnManager manager;

	// Use this for initialization
	void Start () {

        // Ball Respawn Mangerコンポーネントをもったオブジェクトを、Respawnというタグを元に見つけ出す
        GameObject respawnObject = GameObject.FindGameObjectWithTag("Respawn");

        // 探し出したオブジェクトから、BallRespawnManagerコンポーネントを取得して、managerに入れておく
        manager = respawnObject.GetComponent<BallRespawnManager>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    /// <summary>
    /// このオブジェクトと他のオブジェクトが衝突を起こした時に呼び出される
    /// </summary>
    /// <param name="collision">衝突に関する情報</param>
    void OnCollisionEnter(Collision collision)
    {

        // 衝突してきたボールを消滅させる
        Destroy(collision.gameObject);

        // リスポーン（復活）する
        manager.Respawn();
    }
}
