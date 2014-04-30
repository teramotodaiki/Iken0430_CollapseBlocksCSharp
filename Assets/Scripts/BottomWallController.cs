using UnityEngine;
using System.Collections;

/// <summary>
/// 枠の一番下の壁にボールが衝突したとき、ボールを消滅させる
/// </summary>
[RequireComponent(typeof(Collider))]
[AddComponentMenu("C#/Bottom Wall Controller")]
public class BottomWallController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
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
    }
}
