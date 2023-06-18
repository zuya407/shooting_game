using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/// <summary>
/// タイトルのUI制御　主にmainシーンへの遷移
/// </summary>
public class TitleUI : MonoBehaviour
{
	/// <summary>
	/// スタートボタン
	/// </summary>
	[SerializeField] private Button _gameStartButton;

	/// <summary>
	/// プレイヤーキャラのアニメ
	/// </summary>
	[SerializeField] private Animator _playerAnimaton;

	// Start is called before the first frame update
	void Start()
	{
		_playerAnimaton.SetBool("Opening", true);
		//ボタンを押したとき
		_gameStartButton.onClick.AddListener(() =>
		{
			//mainシーンに遷移
			SceneManager.LoadScene("main");
		});
		string saveText = "Play";
		int playNum = 0;
		if (PlayerPrefs.HasKey(saveText))
		{
			playNum = PlayerPrefs.GetInt(saveText);
		}
		playNum++;
		PlayerPrefs.SetInt("Play", playNum);
	}

	// Update is called once per frame
	void Update()
	{

	}
}
