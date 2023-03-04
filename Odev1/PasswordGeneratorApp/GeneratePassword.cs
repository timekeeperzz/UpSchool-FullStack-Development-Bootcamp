using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratePasswordApp
{
    public class GeneratePassword
    {
        private const string Numbers = "0123456789";
        private const string LowercaseChars = "abcdefghijklmnopqrstuvwxyz";
        private const string UppercaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string SpecialChars = "!#$@%^&*()";

        private int length = 0; //password length
        private bool invalid =false;
        private string Password;

        private readonly Random random;
        private readonly StringBuilder PasswordBuilder;
        private readonly StringBuilder CharacterSetBuilder;

        public bool AddNumbers { get; set; }
        public bool AddLowercaseChars { get; set; }
        public bool AddUppercaseChars { get; set; }
        public bool AddSpecialChars { get; set; }
        public GeneratePassword()
        {
            random = new Random();
            PasswordBuilder= new StringBuilder();
            CharacterSetBuilder= new StringBuilder();

        }
        
        public void Greeeting()
        {
            Console.WriteLine(Messages.GreetingAndErrorMessages.Stars);
            Console.WriteLine(Messages.GreetingAndErrorMessages.WelcomeMessage);
            Console.WriteLine(Messages.GreetingAndErrorMessages.Stars);
        }
        public void QuestionsBeforeCreate()
        {
            Console.WriteLine(Messages.GreetingAndErrorMessages.Chitchat);

            AskForAddingChars();

            Console.WriteLine(Messages.Questions.PasswordLength);

            var passwordLength = Console.ReadLine();

            if (!int.TryParse(passwordLength, out length))
            {
                invalid = true;
                return;
            }
            invalid = false;
        }
        public void AskForAddingChars()
        {
            
            // Ask to add numbers and other chars, then read the answer to create password
            Console.WriteLine(Messages.Questions.AddNumbers);

            AddNumbers = Console.ReadLine()?.ToLower() == "y";

            Console.WriteLine(Messages.Questions.AddLowercaseCharacters);

            AddLowercaseChars = Console.ReadLine()?.ToLower() == "y";

            Console.WriteLine(Messages.Questions.AddUppercaseCharacters);

            AddUppercaseChars = Console.ReadLine()?.ToLower() == "y";

            Console.WriteLine(Messages.Questions.AddSpecialCharacters);

            AddSpecialChars = Console.ReadLine()?.ToLower() == "y";

            if (!AddNumbers && !AddLowercaseChars && !AddUppercaseChars &&
               !AddSpecialChars)
            {
                Console.WriteLine(Messages.GreetingAndErrorMessages.Invalid);
                Console.WriteLine(Messages.GreetingAndErrorMessages.TryAgain);
                AskForAddingChars();
            }
        }


        public void CreatePassword()
        {
            if(invalid== true)
            {
                ShowErrorMessage();
            }
            else
            {
                if (AddNumbers)
                    CharacterSetBuilder.Append(Numbers);
                if (AddLowercaseChars)
                    CharacterSetBuilder.Append(LowercaseChars);
                if (AddUppercaseChars)
                    CharacterSetBuilder.Append(UppercaseChars);
                if (AddSpecialChars)
                    CharacterSetBuilder.Append(SpecialChars);

                var SetCharacters=CharacterSetBuilder.ToString();
                for (int i=0;i<length;i++)
                {
                    var randomIndex = random.Next(SetCharacters.Length);
                    PasswordBuilder.Append(SetCharacters[randomIndex]);
                }

                Password=PasswordBuilder.ToString();
                GetThePassword();
            }

        }

        private void ShowErrorMessage(string? message = null)
        {
            if (string.IsNullOrEmpty(message))
            {
                Console.WriteLine(Messages.GreetingAndErrorMessages.Lengthless);
            }

            Console.WriteLine(message);

        }
        public void GetThePassword()
        {
            Console.WriteLine(Messages.GreetingAndErrorMessages.Stars);
            Console.WriteLine(Messages.GreetingAndErrorMessages.CreatedPassword);
            Console.WriteLine(Password);
            Console.WriteLine(Messages.GreetingAndErrorMessages.Stars);
        }
       


    }
}
