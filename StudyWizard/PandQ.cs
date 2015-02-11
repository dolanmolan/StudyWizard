using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyWizard
{
    public class PandQ
    {
        public List<string> playlistNames = new List<string>();
        public List<string> playlistSubjects = new List<string>();
        public List<string> playlistSections = new List<string>();
        public List<Questions> questions = new List<Questions>();
        public string file;
        StreamReader srf;

        public void loadPandQ()
        {
            string tempQuestion;
            string tempQuestionSubject;
            string tempQuestionSection;
            int tempQuestionAnswer;
            string tempQuestionExplain;
            List<string> tempQuestionSelections = new List<string>();
            //FileInfo fileInfo = new FileInfo(file);
            srf = new StreamReader(file);
            string s = "";
            while ((s = srf.ReadLine()) != null)
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
                        tempQuestionSelections.Add(s);
                        break;
                    case 'R':
                        s = s.Remove(0, 2);
                        tempQuestionAnswer = Convert.ToInt32(s);
                        break;
                    case '_':
                        s = s.Remove(0, 2);
                        tempQuestionExplain = s;
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
                    if (line.Contains(playlistNames[selectedPlaylist]))
                        savefile.WriteLine("\rP:" + name);
                    if (line.Contains(playlistNames[selectedPlaylist]))
                        savefile.WriteLine("\rU:" + subject);
                    if (line.Contains(playlistNames[selectedPlaylist]))
                        savefile.WriteLine("\rE:" + section);
                }
            }
            playlistNames[selectedPlaylist] = name;
            playlistSubjects[selectedPlaylist] = subject;
            playlistSections[selectedPlaylist] = section;
        }
    }

    public class Questions
    {
        public string quetion { get; set; }
        public string subject { get; set; }
        public string sections { get; set; }
        public List<string> answers = new List<string>();
        public string answer { get; set; }
        public string explanation { get; set; }
    }
}
