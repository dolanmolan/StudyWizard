using System;
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
        public BindingList<Questions> questions = new BindingList<Questions>();
        public string file;
        static Random random = new Random();


        /// <summary>
        /// Loads a selected text file.
        /// </summary>
        public void loadTextFile()
        {
            playlistNames.Clear();
            playlistSubjects.Clear();
            playlistSections.Clear();
            string tempQuestion = "";
            string tempQuestionSubject = "";
            string tempQuestionSection = "";
            int tempQuestionCorrectAnswer = 0;
            string tempQuestionExplanation = "";
            List<string> tempQuestionAnswers = new List<string>();
            string s = "";
            using (StreamReader streamReader = new StreamReader(file))
            {
                while ((s = streamReader.ReadLine()) != null)
                {
                    switch (s[0])
                    {
                        case 'P':
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
                            tempQuestionAnswers.Add(s);
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
                                section = tempQuestionSection,
                                correctAnswer = tempQuestionCorrectAnswer,
                                explanation = tempQuestionExplanation
                            });
                            tempQuestionAnswers.CopyTo(0, questions[questions.Count - 1].answers, 0, 4);
                            tempQuestionAnswers.Clear();
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// Writes the playlists and questions to the selected text file.
        /// </summary>
        public void saveTextFile()
        {
            using (StreamWriter streamWriter = new StreamWriter(file))
            {
                for (int i = 0; i < playlistNames.Count; i++)
                {
                    streamWriter.WriteLine("P:" + playlistNames[i]);
                    streamWriter.WriteLine("U:" + playlistSubjects[i]);
                    streamWriter.WriteLine("E:" + playlistSections[i]);
                    streamWriter.WriteLine("|");
                }
                for (int i = 0; i < questions.Count; i++)
                {
                    streamWriter.WriteLine("Q:" + questions[i].question);
                    streamWriter.WriteLine("B:" + questions[i].subject);
                    streamWriter.WriteLine("C:" + questions[i].section);
                    for (int j = 0; j < 4; j++)
                    {
                        streamWriter.WriteLine("A:" + questions[i].answers[j]);
                    }
                    streamWriter.WriteLine("R:" + questions[i].correctAnswer);
                    streamWriter.WriteLine("_:" + questions[i].explanation);
                    streamWriter.WriteLine("|");
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
            playlistNames[selectedPlaylist] = name;
            playlistSubjects[selectedPlaylist] = subject;
            playlistSections[selectedPlaylist] = section;
            saveTextFile();
            }

        /// <summary>
        /// Appends a playlist to the text file, as well as adds it to the playlist lists(playlistNames, playlistSubjects, playlistSections).
        /// </summary>
        /// <param name="name">Playlist Name</param>
        /// <param name="subject">Playlist Subject</param>
        /// <param name="section">Playlist Section(s)</param>
        public void saveNewPlaylist(string name, string subject, string section)
        {
            playlistNames.Add(name);
            playlistSubjects.Add(subject);
            playlistSections.Add(section);
            saveTextFile();
        }

        /// <summary>
        /// Removes a specific question, specified by the index of the question in the questions BindingList.
        /// </summary>
        /// <param name="questionIndex">index of the question in the questions BindingList</param>
        public void deleteQuestion(CheckedListBox.CheckedIndexCollection questionIndices)
        {
            for (int i = 0; i < questionIndices.Count; i++)
            {
                questions.RemoveAt(questionIndices[i]);
            }
            saveTextFile();
        }

        /// <summary>
        /// Removes a specific playlist, specified by the index of the playlist name in the playlistNames BindingList.
        /// </summary>
        /// <param name="playlistIndex">index of the playlist name in the playlistNames BindingList</param>
        public void deletePlaylist(int playlistIndex)
        {
            playlistNames.RemoveAt(playlistIndex);
            playlistSubjects.RemoveAt(playlistIndex);
            playlistSections.RemoveAt(playlistIndex);
            saveTextFile();
        }

        /// <summary>
        /// Returns a List of the questions.
        /// </summary>
        /// <returns>Questions and answers</returns>
        public List<string> viewAllQuestions()
        {
            List<string> returnList = new List<string>();
            for (int i = 0; i < questions.Count; i++)
            {
                returnList.Add(questions[i].question);
            }
            return returnList;
        }

        /// <summary>
        /// Adds a new Question object to the questions BindingList.
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
        public void saveNewQuestion(string newQuestion, string newSubject, string newSection, 
            string newAnswer1, string newAnswer2, string newAnswer3, string newAnswer4, 
            int newCorrectAnswer, string newExplanation)
        {
            string[] tempAnswers = new string[] { newAnswer1, newAnswer2, newAnswer3, newAnswer4 };
            questions.Add(new Questions
            {
                question = newQuestion,
                subject = newSubject,
                section = newSection,
                answers = tempAnswers,
                correctAnswer = newCorrectAnswer,
                explanation = newExplanation
            });
            saveTextFile();
        }

        /// <summary>
        /// Changes the properties of a specific question, specified by the index of the question in the questions BindingList
        /// </summary>
        /// <param name="selectedQuestion">index of question being edited</param>
        /// <param name="newQuestion">Question</param>
        /// <param name="newSubject">Question Subject</param>
        /// <param name="newSection">Question Section</param>
        /// <param name="newAnswer1">Question Answer</param>
        /// <param name="newAnswer2">Question Answer</param>
        /// <param name="newAnswer3">Question Answer</param>
        /// <param name="newAnswer4">Question Answer</param>
        /// <param name="newCorrectAnswer">Question Correct Answer</param>
        /// <param name="newExplanation">Question Explanation</param>
        public void saveQuestion(int selectedQuestion, string newQuestion, string newSubject, string newSection, 
            string newAnswer1, string newAnswer2, string newAnswer3, string newAnswer4, 
            int newCorrectAnswer, string newExplanation)
        {
            string[] newAnswers = new string[] { newAnswer1, newAnswer2, newAnswer3, newAnswer4 };
            questions[selectedQuestion].question = newQuestion;
            questions[selectedQuestion].subject = newSubject;
            questions[selectedQuestion].section = newSection;
            questions[selectedQuestion].answers = newAnswers;
            questions[selectedQuestion].correctAnswer = newCorrectAnswer;
            questions[selectedQuestion].explanation = newExplanation;
            saveTextFile();
        }

        /// <summary>
        /// Takes a string of numbers that are separated by commas and converts each of them into doubles
        /// </summary>
        /// <param name="inputString">The string to be converted into doubles</param>
        /// <returns>A List of doubles</returns>
        public List<string> splitString(string inputString)
        {
            List<string> strings = new List<string>();
            string tempString = "";
            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] != ',')
                {
                    tempString += inputString[i];
                }
                else
                {
                    strings.Add(tempString);
                    tempString = "";
                }
            }
            if (tempString != "")
            {
                strings.Add(tempString);
            }
            return strings;
        }

        /// <summary>
        /// takes an index of a specified playlist and finds questions that matched that playlists subject and section(s)
        /// </summary>
        /// <param name="playlistIndex">index of the playlist name in the playlistNames BindingList</param>
        /// <returns>Returns a list of questions that match the specified playlists subject and section(s)</returns>
        public List<Questions> findQuestions(int playlistIndex)
        {
            List<Questions> rightQuestions = new List<Questions>();
            for (int i = 0; i < questions.Count; i++)
            {
                if (splitString(playlistSubjects[playlistIndex]).Contains(questions[i].subject))
                {
                    rightQuestions.Add(questions[i]);
                }
            }
            return rightQuestions;
        }

        /// <summary>
        /// Takes a string array and randomizes the order
        /// </summary>
        /// <param name="inputStringArray">String array to be randomized</param>
        /// <returns>randomized string array</returns>
        public string[] RandomizeStrings(string[] inputStringArray)
        {
            List<KeyValuePair<int, string>> list = new List<KeyValuePair<int, string>>();
            // Add all strings from array
            // Add new random int each time
            foreach (string s in inputStringArray)
            {
                list.Add(new KeyValuePair<int, string>(random.Next(), s));
            }
            // Sort the list by the random number
            var sorted = from item in list
                         orderby item.Key
                         select item;
            // Allocate new string array
            string[] result = new string[inputStringArray.Length];
            // Copy values to array
            int index = 0;
            foreach (KeyValuePair<int, string> pair in sorted)
            {
                result[index] = pair.Value;
                index++;
            }
            // Return copied array
            return result;
        }
    }

    public class Questions
    {
        public string question { get; set; }
        public string subject { get; set; }
        public string section { get; set; }
        public string[] answers = new string[4];
        public int correctAnswer { get; set; }
        public string explanation { get; set; }
    }
}
