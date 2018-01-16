using System;
using System.Configuration;

namespace SecureNuGetServer.BasicAuthentication.Configuration
{
  public class ExcludeElement : ConfigurationElement
  {
    private const string UrlAttribute = "url";
    private const string VerbAttribute = "verb";

    /// <summary>
    ///   Gets or sets the url to exclude.
    /// </summary>
    /// <value>
    ///   The url.
    /// </value>
    [ConfigurationProperty(UrlAttribute, IsRequired = false, IsKey = false)]
    public string Url
    {
      get => Convert.ToString(this[UrlAttribute]);
      set => this[UrlAttribute] = value;
    }

    /// <summary>
    ///   Gets or sets the verb to exclude.
    /// </summary>
    /// <value>
    ///   The verb.
    /// </value>
    [ConfigurationProperty(VerbAttribute, IsRequired = false, IsKey = false)]
    public string Verb
    {
      get => Convert.ToString(this[VerbAttribute]);
      set => this[VerbAttribute] = value;
    }

    public override string ToString()
    {
      return string.Concat(Url, '_', Verb);
    }
  }
}