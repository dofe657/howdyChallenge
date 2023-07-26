using System.Diagnostics;
using Newtonsoft.Json;
using System.Linq;

namespace HowdyChallenge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            string fileName = Methods.SelectFile();
            string jsonString = File.ReadAllText(fileName);
            List<AnswerSheet> sheets = JsonConvert.DeserializeObject<List<AnswerSheet>>(jsonString)!;
            var GroupedSheets = Methods.GetAnswersByGroup(sheets, 0);
            var minimalGroupID = sheets.Min(item => item.GroupId);
            var maximalGroupID = sheets.Max(item => item.GroupId);
            Console.WriteLine(minimalGroupID + " " + maximalGroupID);
            for (int i = minimalGroupID; i <= maximalGroupID; i++)
            {
                var evaluation = Methods.GetEvaluation(Methods.GetAnswersByGroup(sheets, i));
                richTextBox1.AppendText("Average answers for group: " + i + "\n");
                for (int j = 0; j < evaluation.Length; j++)
                {
                    richTextBox1.AppendText("Answer " + j + " = " + evaluation[j] + "\n");
                }
                richTextBox1.AppendText("---------------\n");
            }
        }
    }
}