# GitHub User Activity CLI

A command-line tool built with **C# (.NET 9)** that fetches and summarizes a GitHub user's recent public activity — commits, stars, issues, pull requests, and more.

Inspired by the [GitHub User Activity project on roadmap.sh](https://roadmap.sh/projects/github-user-activity).

---

## 🚀 Features

- 🔍 Fetches the latest **public activity** of any GitHub user
- 📦 Summarizes events like:
  - Pushed commits
  - Starred repositories
  - Opened issues or pull requests
  - Forked or created repositories
- 📊 Groups identical actions and shows how many times they occurred
- ✅ Clean output straight to your terminal

---

## 🔧 Requirements

- [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download)
- Internet connection (uses the GitHub API)

---

## 📥 Installation

```bash
git clone https://github.com/Kamiyumi/GitHubUserActivityCLI.git
cd GitHubUserActivityCLI
```

---

## ▶️ Usage

Run the application using:

```bash
dotnet run
```

Then, when prompted:

```
Enter a GitHub username:
```

Type a valid username like `kamranahmedse`, `sindresorhus`, or your own.

---

### 💡 Example Output:

```
Enter a GitHub username:
kamranahmedse

3× Pushed to kamranahmedse/developer-roadmap
1× Opened a new issue in kamranahmedse/developer-roadmap
1× Starred kamranahmedse/developer-roadmap
```

---

## 🛠 Tech Stack

- C#
- .NET 9
- GitHub REST API
- `HttpClient` & `System.Text.Json`

---

## 🙌 Contributing

Pull requests are welcome! If you find bugs or want to add features, feel free to fork the repo and submit a PR.

---

## 📄 License

MIT License

---

_This project is part of the [roadmap.sh open-source projects](https://roadmap.sh/projects/github-user-activity)._
```
