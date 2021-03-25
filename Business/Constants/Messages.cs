using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string AuthorizationDenied = "Authorization denied.";
        public static string UserRegistered = "Successfully Registered.";
        public static string UserNotFound = "User not found.";
        public static string PasswordError = "Wrong Password.";
        public static string SuccessfulLogin = "Successful login.";
        public static string UserAlreadyExists = "User already exists.";
        public static string AccessTokenCreated = "Access token created.";
    }
}