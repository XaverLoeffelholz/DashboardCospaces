using UnityEngine;
using System.Collections;

public class PageManager : MonoBehaviour {

	public Project[] projectsY0;
	public Project[] projectsY1;
	public Project[] projectsY2;

	private Project[,] projectsAll;


	// Use this for initialization
	void Start () {
		//projects = this.transform.GetComponentsInChildren<Project> ();
		projectsAll = new Project[3,5];

		projectsAll [0,0] = projectsY0[0];
		projectsAll [0,1] = projectsY0[1];
		projectsAll [0,2] = projectsY0[2];
		projectsAll [0,3] = projectsY0[3];
		projectsAll [0,4] = projectsY0[4];

		projectsAll [1,0] = projectsY1[0];
		projectsAll [1,1] = projectsY1[1];
		projectsAll [1,2] = projectsY1[2];
		projectsAll [1,3] = projectsY1[3];
		projectsAll [1,4] = projectsY1[4];

		projectsAll [2,0] = projectsY2[0];
		projectsAll [2,1] = projectsY2[1];
		projectsAll [2,2] = projectsY2[2];
		projectsAll [2,3] = projectsY2[3];
		projectsAll [2,4] = projectsY2[4];
	}
	
	// Update is called once per frame
	void Update () {
	
	}



}
