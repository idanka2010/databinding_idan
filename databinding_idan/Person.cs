﻿namespace databinding_idan
{
    public class Person
    {
        private string email;
        private string password;

        public string Email
        {
            get => email;
            set => email = value;
        }

        public string Password
        {
            get => password;
            set => password = value;
        }
    }
}
