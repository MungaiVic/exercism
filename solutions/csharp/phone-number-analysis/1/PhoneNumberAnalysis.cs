using System;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        bool IsNewYork = phoneNumber.Split("-")[0] == "212";
        bool IsFake = phoneNumber.Split("-")[1] == "555";
        return (IsNewYork, IsFake, phoneNumber.Split("-")[2]);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}
