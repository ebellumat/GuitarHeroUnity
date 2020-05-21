using UnityEngine;

[System.Serializable]
public class PlayerInput
{
	public int deviceId;
	public Device device;
	public bool[] fred;
	public bool strumPressed;
	public bool startPressed;
	public bool starPressed;
	public float tilt, whammy;

	public enum Device
	{
		Keyboard,
		Xinput
	}
	public PlayerInput(Device _device, int _deviceId)
	{
		device = _device;
		deviceId = _deviceId;
		fred = new bool[5];
	}
	public void Update()
	{
		fred[0] = Input.GetKey("1");
		fred[1] = Input.GetKey("2");
		fred[2] = Input.GetKey("3");
		fred[3] = Input.GetKey("4");
		fred[4] = Input.GetKey("5");
		startPressed = Input.GetKey("enter");
		starPressed = Input.GetKey("6");
		strumPressed = true;
		tilt = 0.0f;
		whammy = 0.0f;
	}
}

