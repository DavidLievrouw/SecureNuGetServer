﻿using System.Configuration;

namespace SecureNuGetServer.BasicAuthentication.Configuration
{
  [ConfigurationCollection(typeof(CredentialElement), CollectionType = ConfigurationElementCollectionType.BasicMap)]
  public class CredentialElementCollection : ConfigurationElementCollection
  {
    public CredentialElement this[int index]
    {
      get => (CredentialElement) BaseGet(index);
      set
      {
        if (BaseGet(index) != null) BaseRemoveAt(index);
        BaseAdd(index, value);
      }
    }

    protected override ConfigurationElement CreateNewElement()
    {
      return new CredentialElement();
    }

    protected override object GetElementKey(ConfigurationElement element)
    {
      return ((CredentialElement) element).UserName;
    }
  }
}