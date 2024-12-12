namespace M13.InterviewProject.BLL.Models;

// было бы неплохо оставить здесь комментарии к свойствам
public class SpellerErrors
{
    public int Code { get; set; }
    
    public int Pos { get; set; }
    
    public int Row { get; set; }
    
    public int Col { get; set; }
    
    public int Len { get; set; }
    
    public string Word { get; set; }
    
    public string[] S { get; set; }
}