public class Coach
{
    public string CoachID { get; set; }
    public string FullName { get; set; }
    public string Specialization { get; set; }

    public Coach(string coachID, string fullName, string specialization)
    {
        CoachID = coachID;
        FullName = fullName;
        Specialization = specialization;
    }

    public override string ToString()
    {
        return $"ID: {CoachID}, Name: {FullName}, Specialization: {Specialization}";
    }
}