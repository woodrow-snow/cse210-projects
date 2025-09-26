using System.Runtime.CompilerServices;
using System.Collections.Generic;

class Video
{
    private string _videoTitle;
    private string _author;
    private int _videoLength;
    private List<Comment> _comments;

    public Video(string title, string author, int length, List<Comment> commnets)
    {
        _videoTitle = title;
        _author = author;
        _videoLength = length;
        _comments = new List<Comment>(commnets);
    }

    private int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public string GetVideoInfo()
    {
        return $"{_videoTitle} by {_author}: {_videoLength} seconds long with {GetNumberOfComments()} comments";
    }

    public void PrintComments()
    {
        foreach (Comment comment in _comments) {
            Console.WriteLine(comment.GetFullComment());
        }
    }
}