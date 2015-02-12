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
        public List<Questions> questions = new List<Questions>();
        public string file;
        StreamReader srf;
        public int numberOfPlaylists = 0;

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
