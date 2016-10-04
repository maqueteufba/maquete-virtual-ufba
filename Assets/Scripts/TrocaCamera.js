#pragma strict

var cam1 : Camera ;
var cam2 : Camera;

function Start() {
    cam1.enabled = true;
    cam2.enabled = false;
}
 
function Update() {
 
    if (Input.GetKeyUp (KeyCode.C)) {
        
        cam1.enabled = !cam1.enabled;
        cam2.enabled = !cam2.enabled;
       //transform.position = new Vector3(2708.997, -584.0, -3398.0);
        
    }
}
