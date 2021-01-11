@ECHO off
cd src
csc Gallows.cs MainClass.cs
ren MainClass.exe Hangman.exe
move Hangman.exe ..
move words2.txt ..
cd ..