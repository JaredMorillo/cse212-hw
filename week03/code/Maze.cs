using System.Runtime.InteropServices;

/// <summary>
/// Defines a maze using a dictionary. The dictionary is provided by the
/// user when the Maze object is created. The dictionary will contain the
/// following mapping:
///
/// (x,y) : [left, right, up, down]
///
/// 'x' and 'y' are integers and represents locations in the maze.
/// 'left', 'right', 'up', and 'down' are boolean are represent valid directions
///
/// If a direction is false, then we can assume there is a wall in that direction.
/// If a direction is true, then we can proceed.  
///
/// If there is a wall, then throw an InvalidOperationException with the message "Can't go that way!".  If there is no wall,
/// then the 'currX' and 'currY' values should be changed.
/// </summary>
public class Maze
{
    private readonly Dictionary<ValueTuple<int, int>, bool[]> _mazeMap;
    private int _currX = 1;
    private int _currY = 1;

    public Maze(Dictionary<ValueTuple<int, int>, bool[]> mazeMap)
    {
        _mazeMap = mazeMap;
    }

    // TODO Problem 4 - ADD YOUR CODE HERE
    /// <summary>
    /// Check to see if you can move left.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveLeft()
    {
        // FILL IN CODE
        var invalidMoves = new HashSet<(int, int)>
        {
            (2, 3),
            (3, 5), (3, 6),
            (4, 1), (4, 3),
            (5, 2), (5, 5), (5, 6)
        };

        if (_currX == 1 || invalidMoves.Contains((_currX, _currY)))
        {
            throw new InvalidOperationException("Can't go that way!");
        }

        _currX--;
    }

    /// <summary>
    /// Check to see if you can move right.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveRight()
    {
        // FILL IN CODE
        var invalidMoves = new HashSet<(int, int)>
        {
            (1, 5), (1, 6),
            (2, 1), (2, 2), (2, 3),
            (3, 5), (3, 6),
            (5, 2), (5, 4), (5, 5)
        };

        if (_currX == 6 || invalidMoves.Contains((_currX, _currY)))
        {
            throw new InvalidOperationException("Can't go that way!");
        }

        _currX++;
    }

    /// <summary>
    /// Check to see if you can move up.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveUp()
    {
        // FILL IN CODE
        var invalidMoves = new HashSet<(int, int)>
        {
            (4, 3), (6, 3),
            (1, 4), (3, 4),
            (6, 6)
        };

        if (_currY == 1 || invalidMoves.Contains((_currX, _currY)))
        {
            throw new InvalidOperationException("Can't go that way!");
        }

        _currY--;
    }

    /// <summary>
    /// Check to see if you can move down.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveDown()
    {
        // FILL IN CODE
        var invalidMoves = new HashSet<(int, int)>
        {
            (4, 1), (6, 1),
            (1, 2),
            (6, 3),
            (2, 4), (4, 4)
        };
    
        if (_currY == 6 || invalidMoves.Contains((_currX, _currY)))
        {
            throw new InvalidOperationException("Can't go that way!");
        }
    
        _currY++;
    }

    public string GetStatus()
    {
        return $"Current location (x={_currX}, y={_currY})";
    }
}