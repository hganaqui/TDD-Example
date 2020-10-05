using System;

[Serializable]
public class EntityException : Exception
{
	public EntityException(string message) : base(message) { }

}
