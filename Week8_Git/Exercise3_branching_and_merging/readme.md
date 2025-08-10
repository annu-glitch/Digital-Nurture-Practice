# Git Branching and Merging Demo

This repository demonstrates how to create and work with branches in Git, as well as how to merge changes between branches.

---

## Part 1: Branching

### 1. Create a new branch
```bash
git branch GitNewBranch
```
Creates a new branch named `GitNewBranch`.

### 2. List all branches
```bash
git branch -a
```
- Shows all local and remote branches.
- The `*` mark indicates the current branch.

### 3. Switch to the new branch
```bash
git checkout GitNewBranch
```
(Alternatively)
```bash
git switch GitNewBranch
```

### 4. Add new files to the branch
```bash
echo "This is a file in GitNewBranch" > branchfile.txt
echo "More content for the branch" > anotherfile.txt
```

### 5. Stage and commit changes
```bash
git add branchfile.txt anotherfile.txt
git commit -m "Add files in GitNewBranch"
```

### 6. Check branch status
```bash
git status
```
Shows the current branch and working tree status.

---

## Part 2: Merging

### 1. Switch to master branch
```bash
git checkout master
```
(Alternatively)
```bash
git switch master
```

### 2. View CLI differences between branches
```bash
git diff master GitNewBranch
```
Displays text-based differences.

### 3. View visual differences with P4Merge (optional)
```bash
git config --global merge.tool p4merge
git mergetool
```
Requires P4Merge to be installed.

### 4. Merge `GitNewBranch` into `master`
```bash
git merge GitNewBranch
```

### 5. View commit history after merge
```bash
git log --oneline --graph --decorate
```
- `--graph`: shows branch/merge lines  
- `--decorate`: shows branch and tag names  
- `--oneline`: shortens commit messages

### 6. Delete the branch
```bash
git branch -d GitNewBranch
```
Deletes the branch locally after merge.

### 7. Check final status
```bash
git status
```
Ensures you are on `master` and that the branch is deleted.

---

**Result:**  
- Successfully created and worked in a separate branch.  
- Merged branch changes back into `master`.  
- Branch was safely deleted after merge.
