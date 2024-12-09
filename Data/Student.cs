namespace efcoreApp.Data 
{
    public class Student 
    {
      //id=>primary key
        public int StudentId { get; set; }
        public string? StudentName { get; set; }
        public string? StudentSurName { get; set; }
        public string? Email { get; set; }

         public string? PhoneNumber { get; set; }
    }
}