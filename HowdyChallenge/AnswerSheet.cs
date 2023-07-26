using Newtonsoft.Json;
using System;

public class AnswerSheet
{
    [JsonProperty("employeeId")]
    public int EmployeeId { get; set; }

    [JsonProperty("groupId")]
    public int GroupId { get; set; }

    [JsonProperty("answeredOn")]
    public DateTime AnsweredOn { get; set; }

    [JsonProperty("answer1")]
    public int Answer1 { get; set; }

    [JsonProperty("answer2")]
    public int Answer2 { get; set; }

    [JsonProperty("answer3")]
    public int Answer3 { get; set; }

    [JsonProperty("answer4")]
    public int Answer4 { get; set; }

    [JsonProperty("answer5")]
    public int Answer5 { get; set; }
}
