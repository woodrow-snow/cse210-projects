class Comment
{
    private string _userName;
    private string _commentText;

    public Comment(string name, string comment)
    {
        _userName = name;
        _commentText = comment;
    }

    public string GetFullComment()
    {
        return $"{_userName}: {_commentText}";
    }
}