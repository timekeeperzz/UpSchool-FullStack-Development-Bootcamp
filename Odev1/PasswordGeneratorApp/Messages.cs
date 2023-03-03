using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratePasswordApp
{
    public static class Messages
    {
        public static class GreetingAndErrorMessages
        {
            public static string WelcomeMessage => "Welcome to the B E S T  P A S S W O R D  M A N A G E R !";
            public static string Stars => "********************************************************";
            public static string Chitchat => "I have some options to create a password for you. Can you answer a few Y/N question?";
            public static string Invalid => "You say no all questions. How can I generate a password for you now ?";
            public static string TryAgain => "Can you answer the question again? Please write Y to at least one. :)";
            public static string Lengthless => "is it possible to have a password with no length? I'm sorry, but I can't create a password for you in this case.";
            public static string CreatedPassword => "Here is the password I created for you! :)";
            
        }
        public static class Questions
        {
            public static string AddNumbers => "Do u want to add Numbers?";
            public static string AddLowercaseCharacters => "Do u want to add lowercase characters?";
            public static string AddUppercaseCharacters => "Do u want to add uppercase characters?";
            public static string AddSpecialCharacters => "Do u want to add special characters?";
            public static string PasswordLength => "Great! The last question! How long do you want to keep your password length?";
    
        }

    }
}
