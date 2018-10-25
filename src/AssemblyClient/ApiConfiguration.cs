using System;
using System.Text;

namespace AssemblyClient
{
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
