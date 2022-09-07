public class Movie
{
    public string title;
    public string rating;
    public int reviewScore;

    public Movie(string title, string rating, int score)
    {
        this.title = title;
        this.reviewScore = score;
        this.rating = rating;
    }

    public override string ToString()
    {
        return $"Title: {title}\nRating: {rating}\nReview Score{reviewScore}\n\n";
    }
}