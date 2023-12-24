using System;

namespace MatrixCalculator
{
    [Serializable]
    public class User
    {
        public string Name { get; }
        public static int UserID { get; private set; } = 0;
        public DateTime CreationDate { get; }

        public User(string name)
        {
            Name = name;
            UserID++;
            CreationDate = DateTime.Now;
        }

        public int GetUserID()
        {
            return UserID;
        }
    }
}
