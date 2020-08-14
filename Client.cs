namespace ClientDB
{
    using System;

    internal class Client
    {
        private string lastName;

        private string firstName;

        private string secondName;

        private int myAge;
        private string clientName;

        public Client(string clientName)
        {
            this.clientName = clientName;
        }

        private void SetNames(string name)
        {
            string[] names = name.Split(new String[] { " ", "." },
                StringSplitOptions.RemoveEmptyEntries);
            int n = names.Length;

            if (n == 1) { firstName = names[0]; }
            // if (n == 0) { print no name enter error }
            else if (n == 2)
            {
                firstName = names[0];
                lastName = names[1];
            }
            else
            {
                firstName = names[0]; secondName = names[1];
                lastName = names[n - 1];
            }
        }

        public bool IsSame(string name)
        {
            string[] names = name.Split(new string[] { " ", "." },
                 StringSplitOptions.RemoveEmptyEntries);
            int n = names.Length;
            return lastName.Equals(names[n - 1]) &&
                firstName.Equals(names[0]);
        }
    }
}
