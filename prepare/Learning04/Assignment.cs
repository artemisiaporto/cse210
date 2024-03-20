public class Assignment
{
    protected string _name;
    private string _topic;
    public Assignment(string name, string topic)
    {
        _name = name;
        _topic = topic;
    }
    //Could use a getter or shich private to protected
    //public string GetName()
    //{
    //    return _name;
    //}
    public string GetSummary()
    {
        return $"{_name} - {_topic}";
    }
}