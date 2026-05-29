using System;
using System;

namespace drinks_info
{
    //detta möjliggör polymorfism då olika validator-typer kan implementera detta gränssitt
    public interface IValidator
    {
        bool Validate(string input);
    }

    //StringValidator implementerar IValidator för att validera bokstäver, snedstreck och mellanrum
    public class StringValidator : IValidator
    {
        //validerar att strängen inte är tom och endast innehåller bokstäver, snedstreck och mellanrum
        public bool Validate(string stringInput)
        {
            if (String.IsNullOrEmpty(stringInput))
            {
                return false;
            }

            //tillåt endast bokstäver, snedstreck och mellanrum
            foreach (char c in stringInput)
            {
                if (!Char.IsLetter(c) && c != '/' && c != ' ')
                    return false;
            }

            return true;
        }
    }

    //implementerar IValidator för att validera numeriska ID:n
    public class IdValidator : IValidator
    {
        //validerar att strängen inte är tom och endast innehåller siffror
        public bool Validate(string stringInput)
        {
            if (String.IsNullOrEmpty(stringInput))
            {
                return false;
            }

            foreach (char c in stringInput)
            {
                if (!Char.IsDigit(c))
                    return false;
            }

            return true;
        }
    }

    //Validator, statisk wrapper-klass för bakåtkompatibilitet
    //delegerar nu till de nya validator-klasserna
    public class Validator
    {
        private static readonly IValidator StringValidatorInstance = new StringValidator();
        private static readonly IValidator IdValidatorInstance = new IdValidator();

        //validerar strängformat med polymorfism
        internal static bool IsStringValid(string stringInput)
        {
            return StringValidatorInstance.Validate(stringInput);
        }

        //validerar ID-format med polymorfism
        public static bool IsIdValid(string stringInput)
        {
            return IdValidatorInstance.Validate(stringInput);
        }
    }
}