using System;
using System.Text;

namespace AssemblyClient
{
    /// <summary>
    /// Provides all configuration required for communicating with the api
    /// </summary>
    public class ApiConfiguration
    {
        /// <summary>
        /// Api token obtained when authorising a school
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// Refresh token obtained when authorising a school
        /// </summary>
        public string RefreshToken { get; set; }

        /// <summary>
        /// Client id obtained when creating an app
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// Client secret obtained when creating an app
        /// </summary>
        public string ClientSecret { get; set; }

        /// <summary>
        /// Print some useful debug information to the console
        /// </summary>
        public bool Debug { get; set; }

        internal string BasicAuth
        {
            get
            {
                var credentials = $"{ClientId}:{ClientSecret}";
                var bytes = ASCIIEncoding.ASCII.GetBytes(credentials);
                var authString = Convert.ToBase64String(bytes);
                return authString;
            }
        }
    }
}
