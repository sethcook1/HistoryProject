This project's code was designed to add more objects in the future, and be easily modifiable.

You shouldn't change anything based on the player's movement and interaction (InspectionScript, mouse_look, PlayerMovement, PickUpScript, OpenMenu) EXCEPT the public variables available in the Inspector.
The scripts are not located on one central object, so if you're confused where to find it, here's where:

Player: hold the scripts InspectionScript, PlayerMovement, and OpenMenu
Camera (Player->Camera): holds the scripts mouse_look and PickUpScript

Additionally are the scripts responsible for the pickupable objects.
A few notes:

All pickupable objects must be a child of the "Objects" GameObject.
The object must be set to have the tag of "canPickUp".
It must have a Rigidbody component and a collider. (default Rigidbody and Box Collider OK)
Two scripts must be added to the object itself:
Pickup Return: this script returns the object to its original location when it is dropped by PickUpScript.
InspectInfo: In order for information to be displayed in the Inspection UI, you must have this script on it.
Public variables for InspectInfo:
	Object Name: The name or title of the object. Will display at the top of the UI.
	Object Info: The information that you would like to be displayed in the box of the UI, such as the historical information of the object.
	Object Scale Size F: this is the scale value that the object will be set to when picked up. Leave it as 1 if you do not want the scale to change. This is useful if the object is too big or too small when picked up.
	Object Scale Size: don't touch this one (it will set itself). This Vector3 is passed to PickUpScript that actually does the scale-setting.
-------------------------------------------------------

Therefore, if you would like to add more objects, simply make sure all the above is true, and then the player will be able to pick it up and inspect it.

for any further questions, you can contact Seth Cook at sethacook@outlook.com.
