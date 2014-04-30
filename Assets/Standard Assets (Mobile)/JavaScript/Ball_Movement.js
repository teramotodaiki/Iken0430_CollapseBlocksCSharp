#pragma strict
var speed = 20.0;
function Start () {
rigidbody.AddForce(
( transform.forward + transform.right )
* speed,
ForceMode.VelocityChange );
}

function Update () {

}