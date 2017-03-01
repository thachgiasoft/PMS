using System;
using System.Data;

namespace PMS.Entities
{
    /// <summary>
    /// Globals
    /// </summary>
    public static class Globals
    {          
        /// <summary>
        /// Get last name.
        /// </summary>
        /// <param name="fullName"></param>
        /// <returns></returns>
        public static string GetLastName(string fullName)
        {
            string result = string.Empty;
            try
            {
                string pupilName = fullName.Trim().Replace(' ', '#');
                if (!pupilName.Contains("#"))
                    return string.Empty;
                string[] token = pupilName.Split('#');
                result = token[0].ToString();
            }
            catch
            {
            }
            return result;
        }

        /// <summary>
        /// Get middle name.
        /// </summary>
        /// <param name="fullName"></param>
        /// <returns></returns>
        public static string GetMiddleName(string fullName)
        {
            string result = string.Empty;
            try
            {
                string pupilName = fullName.Trim().Replace(' ', '#');
                if (!pupilName.Contains("#"))
                    return string.Empty;
                string[] token = pupilName.Split('#');
                if (token.Length == 2)
                    return string.Empty;
                for (int i = 1; i < token.Length - 1; i++)
                    result += token[i].ToString() + " ";
                result = result.Trim();
            }
            catch
            {
            }
            return result;
        }

        /// <summary>
        /// Get first name.
        /// </summary>
        /// <param name="fullName"></param>
        /// <returns></returns>
        public static string GetFirstName(string fullName)
        {
            string result = string.Empty;
            try
            {
                string pupilName = fullName.Trim().Replace(' ', '#');
                if (fullName.Trim() == string.Empty)
                    return string.Empty;
                if (!pupilName.Contains("#"))
                    return pupilName.Trim();
                string[] token = pupilName.Split('#');
                result = token[token.Length - 1].ToString();
            }
            catch
            {
            }
            return result;
        }
    }
}