using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public Camera MainCam;
	public Vector3 CameraPos;
	public Transform PathmakerSphere;
	public float FloorCount;

	// Use this for initialization
	void Start () {
		CameraPos.x = 0f;
		CameraPos.y = MainCam.GetComponent<Transform> ().position.y;
		CameraPos.z=0f;
		MainCam.GetComponent<Transform> ().position = CameraPos;
	}
	
	// Update is called once per frame
	void Update () {
		FloorCount = PathmakerSphere.GetComponent<Pathmaker> ().FloorListCount;
		
			CameraPos.x = PathmakerSphere.GetComponent<Pathmaker> ().XTotal / PathmakerSphere.GetComponent<Pathmaker> ().FloorListCount;
			CameraPos.z = PathmakerSphere.GetComponent<Pathmaker> ().ZTotal / PathmakerSphere.GetComponent<Pathmaker> ().FloorListCount;
		if (PathmakerSphere.GetComponent<Pathmaker> ().FloorListCount > 25 && PathmakerSphere.GetComponent<Pathmaker> ().FloorListCount <= 50) {
			CameraPos.y = 105f;
		} else if (PathmakerSphere.GetComponent<Pathmaker> ().FloorListCount > 50 && PathmakerSphere.GetComponent<Pathmaker> ().FloorListCount <= 75) {
			CameraPos.y = 110f;
		} else if (PathmakerSphere.GetComponent<Pathmaker> ().FloorListCount > 75 && PathmakerSphere.GetComponent<Pathmaker> ().FloorListCount <= 100) {
			CameraPos.y = 115f;
		} else if (PathmakerSphere.GetComponent<Pathmaker> ().FloorListCount > 100 && PathmakerSphere.GetComponent<Pathmaker> ().FloorListCount <= 125) {
			CameraPos.y = 120f;
		} else if (PathmakerSphere.GetComponent<Pathmaker> ().FloorListCount > 125 && PathmakerSphere.GetComponent<Pathmaker> ().FloorListCount <= 150) {
			CameraPos.y = 125f;
		} else if (PathmakerSphere.GetComponent<Pathmaker> ().FloorListCount > 150 && PathmakerSphere.GetComponent<Pathmaker> ().FloorListCount <= 175) {
			CameraPos.y = 130f;
		} else if (PathmakerSphere.GetComponent<Pathmaker> ().FloorListCount > 175 && PathmakerSphere.GetComponent<Pathmaker> ().FloorListCount <= 200) {
			CameraPos.y = 135f;
		} else if (PathmakerSphere.GetComponent<Pathmaker> ().FloorListCount > 200 && PathmakerSphere.GetComponent<Pathmaker> ().FloorListCount <= 225) {
			CameraPos.y = 140f;
		} else if (PathmakerSphere.GetComponent<Pathmaker> ().FloorListCount > 225 && PathmakerSphere.GetComponent<Pathmaker> ().FloorListCount <= 250) {
			CameraPos.y = 145f;
		} else if (PathmakerSphere.GetComponent<Pathmaker> ().FloorListCount > 250 && PathmakerSphere.GetComponent<Pathmaker> ().FloorListCount <= 275) {
			CameraPos.y = 150f;
		} else if (PathmakerSphere.GetComponent<Pathmaker> ().FloorListCount > 275 && PathmakerSphere.GetComponent<Pathmaker> ().FloorListCount <= 300) {
			CameraPos.y = 155f;
		} else if (PathmakerSphere.GetComponent<Pathmaker> ().FloorListCount > 300 && PathmakerSphere.GetComponent<Pathmaker> ().FloorListCount <= 325) {
			CameraPos.y = 160f;
		} else if (PathmakerSphere.GetComponent<Pathmaker> ().FloorListCount > 325 && PathmakerSphere.GetComponent<Pathmaker> ().FloorListCount <= 350) {
			CameraPos.y = 170f;
		} else if (PathmakerSphere.GetComponent<Pathmaker> ().FloorListCount > 350 && PathmakerSphere.GetComponent<Pathmaker> ().FloorListCount <= 375) {
			CameraPos.y = 185f;
		} else if (PathmakerSphere.GetComponent<Pathmaker> ().FloorListCount > 375 && PathmakerSphere.GetComponent<Pathmaker> ().FloorListCount <= 400) {
			CameraPos.y = 200f;
		} else if (PathmakerSphere.GetComponent<Pathmaker> ().FloorListCount > 400 && PathmakerSphere.GetComponent<Pathmaker> ().FloorListCount <= 425) {
			CameraPos.y = 215f;
		} else if (PathmakerSphere.GetComponent<Pathmaker> ().FloorListCount > 425 && PathmakerSphere.GetComponent<Pathmaker> ().FloorListCount <= 450) {
			CameraPos.y = 230f;
		} else if (PathmakerSphere.GetComponent<Pathmaker> ().FloorListCount > 450 && PathmakerSphere.GetComponent<Pathmaker> ().FloorListCount <= 475) {
			CameraPos.y = 245f;
		} else if (PathmakerSphere.GetComponent<Pathmaker> ().FloorListCount > 475 && PathmakerSphere.GetComponent<Pathmaker> ().FloorListCount <= 500) {
			CameraPos.y = 260;
		}

			MainCam.GetComponent<Transform> ().position = CameraPos;
		}

}
