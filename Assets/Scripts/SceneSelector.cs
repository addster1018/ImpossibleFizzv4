using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class SceneSelector : MonoBehaviour
{

    protected static Dictionary<string, int> NamedSceneCatalog = new Dictionary<string, int>
    {
        {"LevelAnnouncementScene", 0},
        {"IntroScene", 1},
        {"MainScene", 2},
        {"MechanicsLevel1", 2},     // To compensate for some sloppiness on our end
        {"GameOverScene", 3},
        {"GravitySuitPowerupScene", 4},
        {"MechanicsLevel2",  5},
        {"MechanicsLevel3", 6},
        {"MechanicsLevel4", 7},
        {"MechanicsLevel5", 8},
        {"LeaderboardScene", 9},
        {"E&MIntroScene", 10},
        {"MagnetismSuitPowerupScene", 11},
        {"E&MLevel1", 12}
    };

    protected static Dictionary<int, int> NumberedLevelCatalog = new Dictionary<int, int>
    {
        {0, 1},
        {1, 2},
        {2, 5},
        {3, 6},
        {4, 7},
        {5, 8},
        {6, 10},
        {7, 11},
        {8, 12}
    };

    public static int GetSceneNumberFromName(string Name)
    {
        // This WILL crash if you pass an invalid name
        // TODO fix
        return NamedSceneCatalog[Name];
    }

    // Values should not be duplicated, so
    // in theory this will never fail. However,
    // it is not guaranteed to work the way you
    // may want it to.
    // That one duplicated value doesn't count -
    // It should still work fine...I think.
    public static string GetSceneNameFromNumber(int number)
    {
        foreach(string Name in NamedSceneCatalog.Keys)
        {
            if (NamedSceneCatalog[Name] == number)
            {
                return Name;
            }
        }
        Debug.LogError("Scene not found!");
        return null;
    }

    public static int GetLevelSceneNumber(int level)
    {
        return NumberedLevelCatalog[level];
    }

    public static void LoadScene(int scene)
    {
        if (scene > GetSceneCount() || scene < 0)
        {
            Debug.LogError("Invalid scene number provided!");
            Debug.Break();
        }
        else
        {
            Debug.Log("Loading scene " + GetSceneNameFromNumber(scene));
            SceneManager.LoadScene(scene);
        }
    }

    public static void LoadScene(string Name)
    {
        Debug.Log("Getting scene " + Name + " by name...");
        LoadScene(GetSceneNumberFromName(Name));
    }

    public static void LoadLevel(int level)
    {
        if (level > GetLevelCount() || level < 0)
        {
            Debug.LogError("Invalid level number provided! Going to last level.");
            LoadScene(GetLevelSceneNumber(GetLevelCount()));
        }
        else
        {
            Debug.Log("Loading level " + level);
            LoadScene(GetLevelSceneNumber(level));
        }
    }

    public static int GetSceneCount()
    {
        return NamedSceneCatalog.Count;
    }

    public static int GetLevelCount()
    {
        return NumberedLevelCatalog.Count;
    }
}