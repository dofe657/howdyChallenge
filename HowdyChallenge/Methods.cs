using System;
using System.Linq;

public static class Methods
{
    public static string SelectFile()
    {
        var dlg = new OpenFileDialog()
        {
            RestoreDirectory = true
        };

        //User didn't select a file so return a default value  
        if (dlg.ShowDialog() != DialogResult.OK)
            return "";

        //Return the file the user selected  
        return dlg.FileName;
    }

    public static List<AnswerSheet> GetAnswersByGroup(List<AnswerSheet> sheets, int groupId)
    {
        var groupedSheets = sheets.Where(sheet => sheet.GroupId == groupId).ToList();
        return groupedSheets;
    }

    public static float[] GetEvaluation(List<AnswerSheet> sheets)
    {
        float[] answers = new float[5];
        int count = 0;
        foreach (var sheet in sheets)
        {
            answers[0] += sheet.Answer1;
            answers[1] += sheet.Answer2;
            answers[2] += sheet.Answer3;
            answers[3] += sheet.Answer4;
            answers[4] += sheet.Answer5;
            count++;
        }
        for (int i =0; i < answers.Length;i++)
        {
            answers[i] = (float)answers[i] / count;
        }
        return answers;
    }
}
