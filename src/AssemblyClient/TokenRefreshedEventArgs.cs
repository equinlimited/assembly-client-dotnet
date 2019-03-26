using System;

namespace AssemblyClient
{
  public class TokenRefreshedEventArgs : EventArgs
  {
    public string Token { get; set; }
  }
}
