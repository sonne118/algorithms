<Query Kind="Program" />

void Main()
{
	public int NumUniqueEmails(string[] emails)
	{
	
		var hashSet = new HashSet<string>();
	
		foreach (var email in emails)
		{
			var at_index = email.IndexOf('@');
			var local = email.Substring(0, at_index);
			var domain = email.Substring(at_index);
	
			var plus_index = local.IndexOf('+');
			if (plus_index >= 0)
				local = local.Substring(0, plus_index);
			local = local.Replace(".", "");
	
			hashSet.Add(local + domain);
		}
	
		return hashSet.Count;
}

// You can define other methods, fields, classes and namespaces here