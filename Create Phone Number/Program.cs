string CreatePhoneNumber(int[] numbers)
{
    string phoneNumber = "(";

    for (int i = 0; i < numbers.Length; i++)
    {
        phoneNumber += numbers[i];

        if(i == 2)
        {
            phoneNumber += ") ";
        }
        if (i == 5)
        {
            phoneNumber += "-";
        }
    }

    return phoneNumber;
}