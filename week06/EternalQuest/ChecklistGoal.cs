public class ChecklistGoal : Goal
{
    private int _target;
    private int _count;
    private int _bonus;

    public ChecklistGoal(string name, string desc, int points, int target, int bonus)
        : base(name, desc, points)
    {
        _target = target;
        _count = 0;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _count++;
        if (_count == _target)
            return _points + _bonus;

        return _points;
    }

    public override bool IsComplete() => _count >= _target;

    public override string GetDisplay()
    {
        return $"[{(_count >= _target ? "X" : " ")}] {_name} ({_count}/{_target})";
    }

    public override string GetSaveString()
    {
        return $"Checklist|{_name}|{_description}|{_points}|{_target}|{_count}|{_bonus}";
    }
}