# Git Demo and Git Ignore Setup

This repository demonstrates basic Git setup, creating a repository, committing files, pushing to a remote, and configuring `.gitignore` to exclude unwanted files.

---

## Part 1: Git Demo - Initial Setup and Commit

### 1. Check Git Version
```bash
git version
```
Checks if Git is installed and shows the installed version.

### 2. Configure Git Username
```bash
git config --global user.name "annu-glitch"
```
Sets the Git username for all repositories on the system.

### 3. Configure Git Email
```bash
git config --global user.email "2205448@kiit.ac.in"
```
Sets the email address to be associated with commits.

### 4. Verify Git Configuration
```bash
git config --global --list
```
Displays all global Git configurations currently set.

### 5. Create Project Folder
```bash
mkdir GitDemo
cd GitDemo
```
Creates a folder named `GitDemo` and navigates into it.

### 6. Initialize Git Repository
```bash
git init
```
Initializes an empty Git repository in the folder.

### 7. Create a File
```bash
echo "Welcome to Git Demo" > welcome.txt
```
Creates a text file with sample content.

### 8. Check Repository Status
```bash
git status
```
Shows untracked files and the current branch.

### 9. Stage the File
```bash
git add welcome.txt
```
Stages the file to be committed.

### 10. Commit the Changes
```bash
git commit -m "Initial commit with welcome.txt"
```
Commits the staged changes to the repository.

### 11. Link Remote Repository
```bash
git remote add origin https://github.com/annu-glitch/GitDemo
```
Links the local repository to the GitHub remote repository.

### 12. Push to Remote Repository
```bash
git push origin master
```
Pushes the committed changes to the remote repository.

---

## Part 2: Configuring `.gitignore`

### 1. Create Files to Ignore
```bash
echo "Test log entry" > debug.log
mkdir log
echo "Log file inside log folder" > log/app.log
```
Creates a `.log` file and a `log` folder.

### 2. Create/Edit `.gitignore`
```bash
notepad .gitignore
```
Add the following rules:
```
*.log
log/
```
- `*.log` ignores all `.log` files.
- `log/` ignores the entire `log` folder.

### 3. Check Repository Status
```bash
git status
```
Confirms that `.log` files and the `log` folder are ignored.

### 4. Stage `.gitignore`
```bash
git add .gitignore
```
Stages the `.gitignore` file.

### 5. Commit `.gitignore`
```bash
git commit -m "Add .gitignore to ignore log files and log folder"
```
Commits the `.gitignore` file.

### 6. Push to Remote Repository
```bash
git push origin master
```

