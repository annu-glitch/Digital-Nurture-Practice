# Git Lab – Pull, Branch, and Push

This lab demonstrates verifying the state of the master branch, creating a new branch, adding work, committing changes, and pushing the branch to the remote repository.

---

## Steps Performed

1. **Verify if master is in a clean state**
   ```bash
   git checkout master
   git status
   ```
   Ensured the working tree was clean before proceeding.

2. **List all available branches**
   ```bash
   git branch -a
   ```
   Displayed both local and remote branches. The current branch is marked with `*`.

3. **Pull the latest changes from remote master**
   ```bash
   git pull origin master
   ```
   Updated local master with any changes from the remote repository.

4. **Create a new branch `Git-T03-HOL_002`**
   ```bash
   git checkout -b Git-T03-HOL_002
   ```
   Created and switched to the new branch.

5. **Add a file to the new branch**
   ```bash
   echo "Work for Git-T03-HOL_002 branch" > hol2.txt
   ```

6. **Stage and commit the file**
   ```bash
   git add hol2.txt
   git commit -m "Add work for Git-T03-HOL_002"
   ```

7. **Push the branch to the remote repository**
   ```bash
   git push origin Git-T03-HOL_002
   ```
   Uploaded the new branch and commits to the remote repository.

8. **Verify changes on remote**
   Checked the GitHub repository to confirm that `Git-T03-HOL_002` exists and contains the committed changes.

---

**Outcome:**
- Master branch was verified as clean.
- A new branch `Git-T03-HOL_002` was created, updated with new work, committed, and pushed to the remote.
- Changes were successfully reflected in the remote repository.
