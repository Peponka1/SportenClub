public class Member
{
    public string MemberID { get; set; }
    public string FullName { get; set; }
    public int Age { get; set; }
    public string MembershipType { get; set; }
    public bool IsActive { get; set; }

    public Member(string memberID, string fullName, int age, string membershipType, bool isActive)
    {
        MemberID = memberID;
        FullName = fullName;
        Age = age;
        MembershipType = membershipType;
        IsActive = isActive;
    }

    public override string ToString()
    {
        return $"ID: {MemberID}, Name: {FullName}, Age: {Age}, Membership Type: {MembershipType}, Active: {IsActive}";
    }
}
