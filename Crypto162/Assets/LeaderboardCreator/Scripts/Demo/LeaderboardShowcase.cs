using System.Collections;
using Dan.Main;
using Dan.Models;
using TMPro;using System.Linq;
using UnityEngine;using System.Collections.Generic;

namespace Dan.Demo
{
    public class LeaderboardShowcase : MonoBehaviour
    {
        [Header("Gameplay:")]
        [SerializeField] private TextMeshProUGUI _playerScoreText;
        
        [Header("Leaderboard Essentials:")]
        [SerializeField] private TMP_InputField _playerUsernameInput;
        [SerializeField] private Transform _entryDisplayParent;
        [SerializeField] private EntryDisplay _entryDisplayPrefab;
        [SerializeField] private CanvasGroup _leaderboardLoadingPanel;

public GameObject entryDisplay;
public int Length;
public GameObject[] obj;
public List<GameObject> objd = new List<GameObject>();
        [Header("Search Query Essentials:")]
        [SerializeField] private TMP_Dropdown _timePeriodDropdown;
        [SerializeField] private TMP_InputField _pageInput, _entriesToTakeInput;
        [SerializeField] private int _defaultPageNumber = 1, _defaultEntriesToTake = 100;

        [Header("Personal Entry:")]
        [SerializeField] private RectTransform _personalEntryPanel;
        [SerializeField] private TextMeshProUGUI _personalEntryText;

        private int _playerScore;
        private GameObject[] _entryDisplays;
        
        private Coroutine _personalEntryMoveCoroutine;

        public void AddPlayerScore()
        {
            _playerScore++;
            _playerScoreText.text = $"Your score: {_playerScore}";
        }
        
        public void Load()
        {
            var timePeriod = 
                _timePeriodDropdown.value == 1 ? Dan.Enums.TimePeriodType.Today :
                _timePeriodDropdown.value == 2 ? Dan.Enums.TimePeriodType.ThisWeek :
                _timePeriodDropdown.value == 3 ? Dan.Enums.TimePeriodType.ThisMonth :
                _timePeriodDropdown.value == 4 ? Dan.Enums.TimePeriodType.ThisYear : Dan.Enums.TimePeriodType.AllTime;

            var pageNumber = int.TryParse(_pageInput.text, out var pageValue) ? pageValue : _defaultPageNumber;
            pageNumber = Mathf.Max(1, pageNumber);
            _pageInput.text = pageNumber.ToString();
            
            var take = int.TryParse(_entriesToTakeInput.text, out var takeValue) ? takeValue : _defaultEntriesToTake;
            take = Mathf.Clamp(take, 1, 100);
            _entriesToTakeInput.text = take.ToString();
            
            var searchQuery = new LeaderboardSearchQuery
            {
                Skip = (pageNumber - 1) * take,
                Take = take,
                TimePeriod = timePeriod
            };
            
            _pageInput.image.color = Color.white;
            _entriesToTakeInput.image.color = Color.white;
            
            Leaderboards.FOV.GetEntries(searchQuery, OnLeaderboardLoaded, ErrorCallback);
            ToggleLoadingPanel(true);
            Invoke("pukimay",5);
        }
        void pukimay()
        {
            ToggleLoadingPanel(false);
        }

        public void ChangePageBy(int amount)
        {
            var pageNumber = int.TryParse(_pageInput.text, out var pageValue) ? pageValue : _defaultPageNumber;
            pageNumber += amount;
            if (pageNumber < 1) return;
            _pageInput.text = pageNumber.ToString();
        }
        
        private void OnLeaderboardLoaded(Entry[] entries)
        {
            for (int i = 0; i < obj.Length; i++)
            {
                if (i < entries.Length)
                {
                   obj[i].SetActive(true);
                    obj[i].GetComponent<EntryDisplay>().SetEntry(entries[i]);
                }
                else
                {
                   //obj[i].SetActive(false);
                }
            }

            ToggleLoadingPanel(false);
            
        }
        
        private void ToggleLoadingPanel(bool isOn)
        {
            _leaderboardLoadingPanel.alpha = isOn ? 1f : 0f;
            _leaderboardLoadingPanel.interactable = isOn;
            _leaderboardLoadingPanel.blocksRaycasts = isOn;
        }

        public void MovePersonalEntryMenu(float xPos)
        {
            if (_personalEntryMoveCoroutine != null) 
                StopCoroutine(_personalEntryMoveCoroutine);
            _personalEntryMoveCoroutine = StartCoroutine(MoveMenuCoroutine(_personalEntryPanel, 
                new Vector2(xPos, _personalEntryPanel.anchoredPosition.y)));
        }

        private IEnumerator MoveMenuCoroutine(RectTransform rectTransform, Vector2 anchoredPosition)
        {
            const float duration = 0.25f;
            var time = 0f;
            var startPosition = rectTransform.anchoredPosition;
            while (time < duration)
            {
                time += Time.deltaTime;
                rectTransform.anchoredPosition = Vector2.Lerp(startPosition, anchoredPosition, time / duration);
                yield return null;
            }
            
            rectTransform.anchoredPosition = anchoredPosition;
            _personalEntryMoveCoroutine = null;
        }
        
        private void CreateEntryDisplay(Entry entry)
        {
           foreach(GameObject entryDisplayy in obj)
           {
            entryDisplayy.GetComponent<EntryDisplay>().SetEntry(entry);
           }
        }

        private IEnumerator LoadingTextCoroutine(TMP_Text text)
        {
            var loadingText = "Loading";
            for (int i = 0; i < 3; i++)
            {
                loadingText += ".";
                text.text = loadingText;
                yield return new WaitForSeconds(0.25f);
            }
            
            StartCoroutine(LoadingTextCoroutine(text));
        }

        private void InitializeComponents()
        {
            StartCoroutine(LoadingTextCoroutine(_leaderboardLoadingPanel.GetComponentInChildren<TextMeshProUGUI>()));

            _pageInput.onValueChanged.AddListener(_ => _pageInput.image.color = Color.yellow);
            _entriesToTakeInput.onValueChanged.AddListener(_ => _entriesToTakeInput.image.color = Color.yellow);

            _pageInput.placeholder.GetComponent<TextMeshProUGUI>().text = _defaultPageNumber.ToString();
            _entriesToTakeInput.placeholder.GetComponent<TextMeshProUGUI>().text = _defaultEntriesToTake.ToString();
        }
        
        private void InitializeEntryDisplays(int count)
        {
            _entryDisplays = new GameObject[count];
            
            for (int i = 0; i < count; i++)
            {
                GameObject entryDisplayd = obj[count];
              //  entryDisplayd.SetActive(false); // Hide initially
                _entryDisplays[i] = entryDisplayd;
            }
        }

        private void Start()
        {Application.targetFrameRate = 90;
            Pukus();
          Invoke("pusi",0.2f);
        }
        void pusi()
        {
              InitializeComponents();
          //  InitializeEntryDisplays(_defaultEntriesToTake); // Initialize with a default number of entries
            Load();
        }
        void Pukus()
        {
            for(int x=0;x<Length;x++)
            {
            entryDisplay = Instantiate(_entryDisplayPrefab.gameObject, _entryDisplayParent);
            entryDisplay.GetComponent<EntryDisplay>().pukimay = x+1;
            entryDisplay.GetComponent<EntryDisplay>()._usernameText.text = "Room "+(x+1);
            objd.Add(entryDisplay);
            }
            obj = objd.ToArray();
        }

        public void p()
        {
            Leaderboards.FOV.UploadNewEntry("Room "+PlayerPrefs.GetInt("Room")+">", 0, Callback, ErrorCallback);
        }
         public void e()
        {
            Leaderboards.FOV.UploadNewEntry("Room "+PlayerPrefs.GetInt("Room"), 0, Callback, ErrorCallback);
        }
   
        
        public void DeleteEntry()
        {
            Leaderboards.FOV.DeleteEntry(Callback, ErrorCallback);
        }

        public void ResetPlayer()
        {
            LeaderboardCreator.ResetPlayer();
        }

        public void GetPersonalEntry()
        {
            Leaderboards.FOV.GetPersonalEntry(OnPersonalEntryLoaded, ErrorCallback);
        }

        private void OnPersonalEntryLoaded(Entry entry)
        {
            _personalEntryText.text = $"{entry.RankSuffix()}. {entry.Username} : {entry.Score}";
            MovePersonalEntryMenu(0f);
        }
        
        private void Callback(bool success)
        {
            if (success)
                Load();
        }
        
        private void ErrorCallback(string error)
        {
            Debug.LogError(error);
        }
    }
}
