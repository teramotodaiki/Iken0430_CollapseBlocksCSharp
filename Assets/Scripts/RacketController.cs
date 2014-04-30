using UnityEngine;
using System.Collections;

/// <summary>
/// ラケットを操作する
/// </summary>
[RequireComponent(typeof(Rigidbody))]
[AddComponentMenu("C#/Racket Controller")]
public class RacketController : MonoBehaviour {

    /// <summary>
    /// ラケットの動く速さ（正確には、加速度）
    /// </summary>
    public float Acceleration = 1000f;

	// Use this for initialization
	void Start () {
	
	}
	
	/// <summary>
	/// 非常に短い時間間隔（1/60秒程度）で呼び出される
	/// </summary>
    void Update () {
	    
        // 入力された方向に加速度を与え、ラケットを動かす
        rigidbody.AddForce(transform.right * Input.GetAxisRaw("Horizontal") * Acceleration, ForceMode.Impulse);
	}
}
