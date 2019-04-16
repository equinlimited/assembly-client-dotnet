/**
 * Assembly Developer API .NET Client
 * Version 1.1.0
 *
 * Support
 * Email: help@assembly.education
 * URL:   http://developers.assembly.education
 *
 * Terms of Service: http://assembly.education/terms/
 * License:          MIT, https://spdx.org/licenses/MIT.html
 */


using System;

namespace AssemblyClient
{
  public class TokenRefreshedEventArgs : EventArgs
  {
    public string Token { get; set; }
  }
}
