using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class Unit : MonoBehaviour
{
	[SerializeField]
	private string _name;

	[SerializeField]
	private GameObject _gameObject;
}
