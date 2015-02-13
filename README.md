# StudyWizard

## What is StudyWizard?

StudyWizard is a simple study tool created to help reinforce material learned in school.

## Organization in a text file

### Playlists

* Lines starting with 'P' mark a new playlist with the playlist name right after
* Lines starting with 'U' set the subject of the last playlist
* Lines starting with 'E' set the sections(s) of the last playlist

Example:
```
P:Example Playlist
U:Physics
E:6.2
|
P:Example Playlist 2
U:Calculus
E:7.7,7.8
```

### Questions

* Lines starting with 'Q' mark a new question with the question right after
* Lines starting with 'B' set the subject of the last question
* Lines starting with 'C' set the section(s) of the last question
* Lines starting with 'A' set the possible answers of the last question
	* There are four answers per question
* Lines starting with 'R' indicate the index that will have the correct answer for the last question
* Lines starting with '_' set the explanation, if there is one, for the last question

Example:
```
Q:Example Question
B:Physics
C:6.2
A:Yes
A:No
A:Maybe
A:Possibly
R:0
_:Explanation
|
Q:Example Question 2
B:Calculus
C:7.8
A:No
A:Maybe
A:Yes
A:Possibly
R:2
_:Explanation
```

"|" are usually used to separate playlists and questions just for organization