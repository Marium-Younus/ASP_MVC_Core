namespace Whole_Lecture.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Image { get; set; }

    }

    public class UserData
    {
            public static List<User> GetUser()
            {
            List<User> list = new List<User>();
            list.Add(new User() { Id = 1, Name = "John", Age = 20 ,Image= "../files/user1.png" });
            list.Add(new User() { Id = 2, Name = "David", Age = 24,Image = "../files/user2.png" });
            list.Add(new User() { Id = 3, Name = "James", Age = 28, Image = "../files/user3.png" });
            list.Add(new User() { Id = 4, Name = "Sarah", Age = 22, Image = "../files/user4.png" });
            list.Add(new User() { Id = 5, Name = "Jessica", Age = 25, Image = "../files/user5.png" });
            return list;
            }
    }
}
