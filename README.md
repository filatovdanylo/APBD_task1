��\# APBD\_task1

This is my program. Hello everyone

:) 

Explanation:

if we use ‘git show’ command with the hash from the latest merge commit we will be able to see that it has two parent hashes meaning that git performed three-way merge 

Questions:

1) Git performs fast-forward commit only when no new commits were created on the ‘main’ branch since the new branch (feature) was created. Merge conflict occurs when different changes are made to the same part of the code in two separate branches. In this situation, git cannot automatically resolve the conflict

2) ‘Merge’ makes a new commit with combined changes from two branches, while ‘rebase’ detaches a current branch from the commit in the past and attaches the current branch to the latest commit in the source(main) branch. This is done in order to create linear sequence of commits and prepare for a fast-forward commit.

3) The conflict was resolved by just choosing one of two return options in the DummyMethod to make returned string consistent among two conflicting branches 