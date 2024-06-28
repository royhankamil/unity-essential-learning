using TMPro;
using UnityEngine;

public class UIGraphics : MonoBehaviour
{
    private static readonly int LevelEndedHash = Animator.StringToHash("LevelEnded");
    private static readonly int GameOverHash = Animator.StringToHash("GameOver");

    public Animator animator;
    public TMP_Text remainingTargetsText;
    public TMP_Text currentLevelText;

    private LevelController levelController;

    public void EndLevel(int currentLevel)
    {
        currentLevelText.text = $"Level {currentLevel} Finished!";
        animator.SetTrigger(LevelEndedHash);
    }

    public void EndGame()
    {
        animator.SetTrigger(GameOverHash);
    }

    public void OnFinishedEndLevelAnimation()
    {
        levelController.NextLevel();
    }

    public void OnRetryClicked()
    {
        levelController.RetryGame();
    }

    public void Setup(LevelController controller)
    {
        levelController = controller;
    }

    public void UpdateRemainingTargets(int remainingTargets)
    {
        remainingTargetsText.text = $"Remaining Targets: {remainingTargets}!";
    }
}