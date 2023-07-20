using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Builds a level
/// </summary>	
public class LevelBuilder : MonoBehaviour
{
    #region Fields

    [SerializeField]
    GameObject prefabPaddle;

    [SerializeField]
    GameObject prefabStandardBlock;
    [SerializeField]
    GameObject prefabBonusBlock;
    [SerializeField]
    GameObject prefabEffectBlock;

    #endregion

    #region Unity methods

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>	
    void Start()
    {
        Instantiate(prefabPaddle);

        // retrieve block size
        GameObject tempBlock = Instantiate<GameObject>(prefabStandardBlock);
        BoxCollider2D collider = tempBlock.GetComponent<BoxCollider2D>();
        float blockWidth = collider.size.x;
        float blockHeight = collider.size.y;
        Destroy(tempBlock);

        // calculate blocks per row and make sure left block position centers row
        float screenWidth = ScreenUtils.ScreenRight - ScreenUtils.ScreenLeft;
        int blocksPerRow = (int)(screenWidth / blockWidth);
        float totalBlockWidth = blocksPerRow * blockWidth;
        float leftBlockOffset = ScreenUtils.ScreenLeft +
            (screenWidth - totalBlockWidth) / 2 +
            blockWidth / 2;

        float topRowOffset = ScreenUtils.ScreenTop -
            (ScreenUtils.ScreenTop - ScreenUtils.ScreenBottom) / 5 -
            blockHeight / 2;

        // add rows of blocks
        Vector2 currentPosition = new Vector2(leftBlockOffset, topRowOffset);
        for (int row = 0; row < 3; row++)
        {
            for (int column = 0; column < blocksPerRow; column++)
            {
                PlaceBlock(currentPosition);
                currentPosition.x += blockWidth;
            }

            // move to next row
            currentPosition.x = leftBlockOffset;
            currentPosition.y += blockHeight;
        }
    }

    /// <summary>
	/// Update is called once per frame
	/// </summary>	
    void Update()
    {

    }

    #endregion

    #region Private methods

    /// <summary>
    /// Places a randomly-selected block at the given position
    /// </summary>
    /// <param name="position">position of the block</param>
    void PlaceBlock(Vector2 position)
    {
        float randomBlockType = Random.value;
        if (randomBlockType < ConfigurationUtils.StandardBlockProbability)
        {
            Instantiate(prefabStandardBlock, position, Quaternion.identity);
        }
        else if (randomBlockType <
            (ConfigurationUtils.StandardBlockProbability + ConfigurationUtils.BonusBlockProbability))
        {
            Instantiate(prefabBonusBlock, position, Quaternion.identity);
        }
        else
        {
            // effect block selected
            GameObject effectBlock = Instantiate(prefabEffectBlock, position, Quaternion.identity);
            EffectBlock effectBlockScript = effectBlock.GetComponent<EffectBlock>();

            // set effect
            float freezerThreshold = ConfigurationUtils.StandardBlockProbability +
                ConfigurationUtils.BonusBlockProbability +
                ConfigurationUtils.FreezerBlockProbability;
            if (randomBlockType < freezerThreshold)
            {
                effectBlockScript.Effect = EffectName.Freezer;
            }
            else
            {
                effectBlockScript.Effect = EffectName.Speedup;
            }
        }
    }

    #endregion
}
