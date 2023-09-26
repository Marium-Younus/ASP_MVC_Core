namespace Whole_Lecture.Models
{
    public class UserManager
    {

        public static Boolean ValidateUser(string name,string password)
        {
            if (name == "admin" && password == "admin")
            {
                return true;
            }
            else 
            { 
                return false;
            }

        }
    }


}
