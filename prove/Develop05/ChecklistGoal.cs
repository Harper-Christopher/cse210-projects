public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        //In addition to the standard attributes, a checklist goal also needs the target and the bonus amounts. Then, it should set the amount completed to begin at 0.
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        int pointsEarned = 0;

        if (_amountCompleted >= _target)
        {
            // Bonus points awarded when target is reached
            _amountCompleted = _target; 
            pointsEarned = _points + _bonus; 
        }
        
        else 
        {
            pointsEarned = _points;
        }
        GoalManager goalManager = new GoalManager();
        goalManager._score += pointsEarned;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} -- (Completed {_amountCompleted}/{_target} times)";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_target}|{_bonus}|{_amountCompleted}";
    }
}