# GitHub User Activity CLI

A command-line interface (CLI) tool that fetches and displays the recent activity of a specified GitHub user directly in your terminal.

## Overview

This project allows users to input a GitHub username and retrieve their latest public activities, such as repository pushes, issue creations, and stars. It's a practical tool for monitoring user contributions and activities on GitHub.

## Features

- **Fetch Recent Activity**: Retrieve the latest public events of any GitHub user.
- **Display in Terminal**: Presents the fetched activities in a clear and concise format within the terminal.
- **Error Handling**: Gracefully handles errors such as invalid usernames or API failures.

## Usage

```bash
github-activity <username>
```

**Example Output:**

```
- Pushed 3 commits to kamranahmedse/developer-roadmap
- Opened a new issue in kamranahmedse/developer-roadmap
- Starred kamranahmedse/developer-roadmap
```

## Requirements

- **Command-Line Interface**: The application runs from the command line and accepts the GitHub username as an argument.
- **GitHub API Integration**: Utilizes the GitHub API to fetch user activity. Endpoint used:

  ```
  https://api.github.com/users/<username>/events
  ```

  *Example:* `https://api.github.com/users/kamranahmedse/events`

- **Programming Language**: Implemented in a language of your choice without the use of external libraries or frameworks for fetching GitHub activity.
- **Error Handling**: Manages errors gracefully, including invalid usernames and API failures.

## Getting Started

1. **Clone the Repository**:

   ```bash
   git clone https://github.com/yourusername/github-activity-cli.git
   ```

2. **Navigate to the Project Directory**:

   ```bash
   cd github-activity-cli
   ```

3. **Build the Application**:

   ```bash
   # Depending on your chosen programming language
   ```

4. **Run the Application**:

   ```bash
   github-activity <username>
   ```

## Contributing

Contributions are welcome! Please fork the repository and submit a pull request with your enhancements.

## License

This project is licensed under the MIT License. See the LICENSE file for details.

---

*This project is inspired by the [GitHub User Activity project on roadmap.sh](https://roadmap.sh/projects/github-user-activity).* 
