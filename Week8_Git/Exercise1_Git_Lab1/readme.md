# Git Demo - Setup and First Commit

This document describes the steps followed to set up Git, configure user details, create a local repository, and push changes to a remote repository.

## 1. Check Git Version
```bash
git version
```
Checks if Git is installed and shows the installed version.

## 2. Configure Git Username
```bash
git config --global user.name "annu-glitch"
```
Sets the Git username for all repositories on the system.

## 3. Configure Git Email
```bash
git config --global user.email "2205448@kiit.ac.in"
```
Sets the email address to be associated with commits.

## 4. Verify Git Configuration
```bash
git config --global --list
```
Displays all global Git configurations currently set.

## 5. Create Project Folder
```bash
mkdir GitDemo
cd GitDemo
```
Creates a new folder named `GitDemo` and navigates into it.

## 6. Initialize Git Repository
```bash
git init
```
Initializes an empty Git repository in the folder.

## 7. Create a File
```bash
echo "Welcome to Git Demo" > welcome.txt
```
Creates a new text file with the specified content.

## 8. Check Repository Status
```bash
git status
```
Shows the current status of the working directory and staging area.

## 9. Stage the File
```bash
git add welcome.txt
```
Adds the file to the staging area.

## 10. Commit the Changes
```bash
git commit -m "Initial commit with welcome.txt"
```
Saves the staged changes to the repository history with a commit message.

## 11. Link Remote Repository
```bash
git remote add origin https://github.com/annu-glitch/GitDemo
```
Links the local repository to the remote repository on GitHub.

## 12. Push to Remote Repository
```bash
git push origin master
```
Pushes the committed changes from the local repository to the remote repository.
