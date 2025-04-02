```markdown
# GitHub User Activity CLI

A command-line tool built in **C# (.NET 9)** that fetches and summarizes a GitHub user's recent public activity — commits, stars, issues, pull requests, and more.

Inspired by the [GitHub User Activity project on roadmap.sh](https://roadmap.sh/projects/github-user-activity).

---

## 🚀 Features

- 🔍 Fetches the latest **public activity** of any GitHub user
- 📦 Summarizes events like:
  - Pushed commits
  - Starred repositories
  - Opened issues or pull requests
  - Forked or created repositories
- 📊 Groups identical actions and counts them
- ✅ Clean output straight to your terminal

---

## 🔧 Requirements

- [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download) (or higher)
- Internet connection (to access GitHub API)

---

## 📥 Installation

```bash
git clone https://github.com/Kamiyumi/GitHubUserActivityCLI.git
cd GitHubUserActivityCLI
```

---

## ▶️ Usage

Run the CLI with:

```bash
dotnet run <github-username>
```

### Example:

```bash
dotnet run kamranahmedse
```

### Sample Output:

```
3× Pushed to kamranahmedse/developer-roadmap
1× Opened a new issue in kamranahmedse/developer-roadmap
1× Starred kamranahmedse/developer-roadmap
```

---

## 🧠 How It Works

- Uses the public GitHub REST API:
  ```
  GET https://api.github.com/users/<username>/events
  ```
- Maps event types (e.g. `PushEvent`, `WatchEvent`, etc.) into readable actions
- Groups similar actions and counts them

---

## 🛠 Tech Stack

- C#
- .NET 9
- GitHub REST API
- `HttpClient` + `System.Text.Json`

---

## 🙌 Contributing

Contributions are welcome! Feel free to fork this repo and open a pull request.

---

## 📄 License

MIT License

---

_This project is part of the [roadmap.sh open-source projects](https://roadmap.sh/projects/github-user-activity)._  
```
