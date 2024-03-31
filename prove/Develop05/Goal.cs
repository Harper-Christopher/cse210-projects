using System.ComponentModel;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public string GetShortName()
    {
        return _shortName;
    }

    public int GetPoints()
    {
        return _points;
    }

    public Goal(string name, string desciption, int points)
    {
        _shortName = name;
        _description = desciption;
        _points = points;
    }

    public virtual void RecordEvent()
    {
        
    }
    public abstract bool IsComplete();
    
    public virtual string GetDetailsString()
    {
        return $"{_shortName} - {_description}";
    }

    public abstract string GetStringRepresentation();
}