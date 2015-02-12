﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace StudyWizard
{
    public class PandQ
    {
        public BindingList<string> playlistNames = new BindingList<string>();
        public List<string> playlistSubjects = new List<string>();
        public List<string> playlistSections = new List<string>();
        public List<Questions> questions = new List<Questions>();
        public string file;
        StreamReader srf;
        public int numberOfPlaylists = 0;

        /// <summary>
        /// Loads a selected text file.
        /// </summary>
        public void loadPandQ()
        {
            string tempQuestion = "";
            string tempQuestionSubject = "";
            string tempQuestionSection = "";
            int tempQuestionCorrectAnswer = 0;
            string tempQuestionExplanation = "";
            List<string> tempQuestionSelections = new List<string>();
            srf = new StreamReader(file);
            string s = "";
            while ((s = srf.ReadLine()) != null)
            {
                switch (s[0])
                {
                    case 'P':
                        numberOfPlaylists++;
                        s = s.Remove(0, 2);
                        playlistNames.Add(s);
                        break;
                    case 'U':
                        s = s.Remove(0, 2);
                        playlistSubjects.Add(s);
                        break;
                    case 'E':
                        s = s.Remove(0, 2);
                        playlistSections.Add(s);
                        break;
                    case 'Q':
                        s = s.Remove(0, 2);
                        tempQuestion = s;
                        break;
                    case 'B':
                        s = s.Remove(0, 2);
                        tempQuestionSubject = s;
                        break;
                    case 'C':
                        s = s.Remove(0, 2);
                        tempQuestionSection = s;
                        break;
                    case 'A':
                        s = s.Remove(0, 2);
                        tempQuestionSelections.Add(s);
                        break;
                    case 'R':
                        s = s.Remove(0, 2);
                        tempQuestionCorrectAnswer = Convert.ToInt32(s);
                        break;
                    case '_':
                        s = s.Remove(0, 2);
                        tempQuestionExplanation = s;
                        questions.Add(new Questions
                        {
                            question = tempQuestion,
                            subject = tempQuestionSubject,
                            sections = tempQuestionSection,
                            answers = tempQuestionSelections,
                            correctAnswer = tempQuestionCorrectAnswer,
                            explanation = tempQuestionExplanation
                        });
                        break;
                    default:
                        break;
                }
            }

        }

        /// <summary>
        /// Changes the properties of a specific playlist, specified by the index of the playlist name in the playlistNames BindingList
        /// </summary>
        /// <param name="selectedPlaylist">index of the playlist name in the playlistNames BindingList</param>
        /// <param name="name">New Playlist Names</param>
        /// <param name="subject">New Playlist Subject</param>
        /// <param name="section">New Playtlist Section(s)</param>
        public void savePlaylist(int selectedPlaylist, string name, string subject, string section)
        {
            srf.Close();
            srf.Dispose();
            string[] lines = File.ReadAllLines(file);
            using (StreamWriter savefile = new StreamWriter(file))
            {
                foreach (string line in lines)
                {
                    if (!line.Contains(playlistNames[selectedPlaylist]) && !line.Contains(playlistSubjects[selectedPlaylist]) && !line.Contains(playlistSections[selectedPlaylist]))
                    {
                        savefile.WriteLine(line);
                    }
                    if (line.Contains(playlistNames[selectedPlaylist]))
                    {
                        savefile.WriteLine("P:" + name);
                    }
                    if (line.Contains(playlistSubjects[selectedPlaylist]))
                    {
                        savefile.WriteLine("U:" + subject);
                    }
                    if (line.Contains(playlistSections[selectedPlaylist]))
                    {
                        savefile.WriteLine("E:" + section);
                    }
                    playlistNames[selectedPlaylist] = name;
                    playlistSubjects[selectedPlaylist] = subject;
                    playlistSections[selectedPlaylist] = section;
                }
            }
        }

        /// <summary>
        /// Appends a playlist to the text file, as well as adds it to the playlist lists(playlistNames, playlistSubjects, playlistSections).
        /// </summary>
        /// <param name="name">Playlist Name</param>
        /// <param name="subject">Playlist Subject</param>
        /// <param name="section">Playlist Section(s)</param>
        public void savePlaylist(string name, string subject, string section)
        {
            srf.Close();
            srf.Dispose();
            string[] lines = File.ReadAllLines(file);
            using (StreamWriter savefile = new StreamWriter(file))
            {
                foreach (string line in lines)
                {
                    savefile.WriteLine(line);
                }
                playlistNames.Add(name);
                playlistSubjects.Add(subject);
                playlistSections.Add(section);
                savefile.WriteLine("P:" + name);
                savefile.WriteLine("U:" + subject);
                savefile.WriteLine("E:" + section);
                savefile.WriteLine("|");
            }
        }

        /// <summary>
        /// Removes a specific playlist, specified by the index of the playlist name in the playlistNames BindingList.
        /// </summary>
        /// <param name="playlistIndex">index of the playlist name in the playlistNames BindingList</param>
        public void deletePlaylist(int playlistIndex)
        {
            numberOfPlaylists--;
            srf.Close();
            srf.Dispose();
            string[] lines = File.ReadAllLines(file);
            string[] newLines = File.ReadAllLines(file);
            using (StreamWriter savefile = new StreamWriter(file))
            {
                int index = 0;
                foreach (string line in lines)
                {
                    // If the current line does not contain any of the playlist that is going to be deleted, continue.
                    if (!line.Contains(playlistNames[playlistIndex]) && !line.Contains(playlistSubjects[playlistIndex]) && !line.Contains(playlistSections[playlistIndex]))
                    {
                        // If the current line contains a useless "|", don't write.
                        if ((!(index == 0 && line.Contains("|"))) && (!(line.Contains("|") && (lines[index - 1].Contains("|")))))
                        {
                            savefile.WriteLine(line);
                            newLines[index] = line;
                            index++;
                        }
                    }
                }
            }
            playlistNames.RemoveAt(playlistIndex);
            playlistSubjects.RemoveAt(playlistIndex);
            playlistSections.RemoveAt(playlistIndex);
        }

        /// <summary>
        /// Returns an array that hold the question, the answer, and a blank space for each question.
        /// </summary>
        /// <returns>Questions and answers</returns>
        public string[] viewAllQuestions()
        {
            string[] returnString = new string[(questions.Count) * 3];
            for (int i = 0; i < returnString.Length; i += 3)
            {
                returnString[i] = questions[i/3].question;
                returnString[i + 1] = questions[i/3].answers[questions[i/3].correctAnswer];
                returnString[i + 2] = "";
            }
            return returnString;
        }

        /// <summary>
        /// Appends a question to the text file, as well as adds a new Questions object to the questions list.
        /// </summary>
        /// <param name="newQuestion">New Question</param>
        /// <param name="newSubject">New Question Subject</param>
        /// <param name="newSections">New Question Section(s)</param>
        /// <param name="newAnswer1">New Question Answer</param>
        /// <param name="newAnswer2">New Question Answer</param>
        /// <param name="newAnswer3">New Question Answer</param>
        /// <param name="newAnswer4">New Question Answer</param>
        /// <param name="newCorrectAnswer">New Question Correct Answer</param>
        /// <param name="newExplanation">New Question Explanation</param>
        public void addQuestion(string newQuestion, string newSubject, string newSections, string newAnswer1, string newAnswer2, string newAnswer3, string newAnswer4, int newCorrectAnswer, string newExplanation)
        {
            srf.Close();
            srf.Dispose();
            string[] lines = File.ReadAllLines(file);
            List<string> tempAnswers = new List<string>();
            tempAnswers.Add(newAnswer1); tempAnswers.Add(newAnswer2); tempAnswers.Add(newAnswer3); tempAnswers.Add(newAnswer4);
            using (StreamWriter savefile = new StreamWriter(file))
            {
                foreach (string line in lines)
                {
                    savefile.WriteLine(line);
                }
                questions.Add(new Questions
                {
                    question = newQuestion,
                    subject = newSubject,
                    sections = newSections,
                    answers = tempAnswers,
                    correctAnswer = newCorrectAnswer,
                    explanation = newExplanation
                });
                savefile.WriteLine("Q:" + newQuestion);
                savefile.WriteLine("B:" + newSubject);
                savefile.WriteLine("C:" + newSections);
                savefile.WriteLine("A:" + newAnswer1);
                savefile.WriteLine("A:" + newAnswer2);
                savefile.WriteLine("A:" + newAnswer3);
                savefile.WriteLine("A:" + newAnswer4);
                savefile.WriteLine("R:" + newCorrectAnswer);
                savefile.WriteLine("_:" + newExplanation);
                savefile.WriteLine("|");
            }
        }
    }

    public class Questions
    {
        public string question { get; set; }
        public string subject { get; set; }
        public string sections { get; set; }
        public List<string> answers = new List<string>();
        public int correctAnswer { get; set; }
        public string explanation { get; set; }
    }
}
