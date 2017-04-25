/*
 * Name: Ben Schmidt
 * Project: Final Project
 * Date: 4/26/2017
 */
namespace CS292_FinalProject_BenSchmidt
{
    /// <summary>
    /// The purpose of this class is to store essential information
    /// about any player and display said information when prompted.
    /// </summary>
    public class Player
    {
        private int id;
        private string name;
        private string position;
        private string school;
        private string standing;

        public int Id { get { return id; } }
        public string Name { get { return name; } }
        public string Position { get { return position; } }
        public string School { get { return school; } }
        public string Standing { get { return standing; } }

        public Player(string newName, string newPosition, string newSchool, string newStanding)
        {
            name = newName;
            position = newPosition;
            school = newSchool;
            standing = newStanding;
        }

        public Player(int newID, string newName, string newPosition, string newSchool, string newStanding)
        {
            id = newID;
            name = newName;
            position = newPosition;
            school = newSchool;
            standing = newStanding;
        }
    }
}
