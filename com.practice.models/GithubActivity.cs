namespace GitHubUserActivityCLI.com.practice.models;

public class GitHubActivity
{
    public string? Id { get; set; }
    public string? Type { get; set; }
    public bool Public { get; set; }
    public DateTime CreatedAt { get; set; }
    public ActorData? Actor { get; set; }
    public RepoData? Repo { get; set; }
    public PayloadData? Payload { get; set; }

    public class ActorData
    {
        public int Id { get; set; }
        public string? DisplayLogin { get; set; }
        public string? GravatarId { get; set; }
        public string? Url { get; set; }
        public string? AvatarUrl { get; set; }
        public string? Login { get; set; }
    }

    public class RepoData
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Url { get; set; }
    }

    public class PayloadData
    {
        // WatchEvent
        public string? Action { get; set; }

        // PushEvent
        public long? PushId { get; set; }
        public int? Size { get; set; }
        public int? DistinctSize { get; set; }
        public string? Ref { get; set; }
        public string? Head { get; set; }
        public string? Before { get; set; }
        public List<CommitData>? Commits { get; set; }
    }

    public class CommitData
    {
        public string? Sha { get; set; }
        public CommitAuthor? Author { get; set; }
        public string? Message { get; set; }
        public bool Distinct { get; set; }
        public string? Url { get; set; }
    }

    public class CommitAuthor
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
    }
}

