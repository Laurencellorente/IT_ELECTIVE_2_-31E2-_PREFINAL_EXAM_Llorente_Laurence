namespace IT_ELECTIVE_2_SECTION_PREFINAL_EXAM_Lastname_Firstname.Models
{
    public class QuestionAnswer
    {
        public int Number { get; set; }
        public string Question { get; set; } = string.Empty;
        public string[] Choices { get; set; } = Array.Empty<string>();
        public string Answer { get; set; } = string.Empty;
    }
}