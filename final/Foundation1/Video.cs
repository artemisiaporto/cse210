using System.Transactions;

public class Video
{
    public string _title;
    public string _author;
    public int _length; //in seconds
    public List<Comment> _comments;

    public int NumberOfComments(List<Comment> comments)
    {
        return comments.Count();
    }

    public void SetInfo(string title, string author, int length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
    }
}