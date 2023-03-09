<Query Kind="Program" />

void Main()
{
	 string s = "twn", t = "txxxxxxxxxxxwxxxxxxxxxxxxxxxxxxxxxxxxxn";
	 Console.WriteLine(IsSubsequence(s, t));
}
public bool IsSubsequence(string s, string t)
{
	if(String.IsNullOrEmpty(s))
	   return false;
	  
   var arr1 = t.ToList();
   var arr2 = s.ToList();

	for (int j = 0; j <= arr2.Count-1; j++)
	{
		for (int i = 0; i <= arr1.Count-1; i++)
        { 				   	    	
			if (!arr2.Contains(arr1[i]))
			{				
				arr1.RemoveAt(i);				
			}			
		}	
    }
if(arr1.SequenceEqual(arr2))
return true;
else
return false;

}