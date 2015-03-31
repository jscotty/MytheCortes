using UnityEngine;
using System.Collections;

public class TempleEntrance : MonoBehaviour {
	public SaveLoadDataSerialized save;
	public int level;
	public GameObject bees;
	public AudioClip audioClip;
	public TalkScript talk;

	private AudioSource _audio;
	private Animator _anim;

	enum Item{Nothing = 0, Carrot = 1, Corn = 2};

	public void CheckRequirements(){
		int[] questItem = QuestData.questItems;
		_anim = gameObject.GetComponent<Animator> ();
		_audio = gameObject.GetComponent<AudioSource> ();
			CheckItems ((Item)questItem [0]);



	}

	void CheckItems(Item item){
		int questDone = QuestData.questDone;
		int quest = QuestData.quest;


		switch (item) {
		case Item.Nothing:
			if (questDone >= 4) {
				_anim.SetBool(AnimNames.OPEN, true);
				_audio.PlayOneShot(audioClip,1f);
				talk.StopTalk();
			} else {

			}
			break;
		case Item.Carrot:
			if (questDone >= 4) {
				_anim.SetBool(AnimNames.OPEN, true);
				_audio.PlayOneShot(audioClip,1f);
			} else {
				//QuestData.questDone = 3;
				QuestData.questDone ++;
				QuestData.quest ++;
				QuestData.questProgress = 0;
				QuestData.questItems[0] = 0;
				QuestData.levelSpot = 0;
				_anim.SetBool(AnimNames.OPEN, true);
				_audio.PlayOneShot(audioClip,1f);
			}
			talk.StopTalk();
			break;
		case Item.Corn:
			talk.StopTalk();
			bees.SetActive(true);
			QuestData.questItems[0] = 0;
			if (quest == 3) {
				QuestData.questProgress = 50;
			}
			talk.StartTalk(Names.BEES);
			break;
		default:
			break;
		}
	}

	public void Load(){
		LoadingScreen.isLoading = true;
		Application.LoadLevel(level);
			save.Save();

	}
}
