namespace cab301
{
  class Member : iMember
  {
    public string FirstName  { get; set; }

    public string LastName { get; set; }

    public string ContactNumber { get; set; }

    public string PIN { get; set; }

    private string[] _tools;
    public string[] Tools {
      get => _tools;
    }

    public void addTool (iTool tool) {

    }

    public void deleteTool (iTool tool) {

    }

    //return a string containing the first name, lastname, and contact phone number of this memeber
    override public string ToString()
    {
      return "";
    }
  }
}