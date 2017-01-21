# Replace Armenian text into translit
# C#6.0  .NET FRAMEWORK 4.6

----
### Purpose
Many Armenians in the world aren't able to understand armenian letters and armenian text. Many of them know armenian language, but know letters. 
This program allow inputed armenian text replace to english, in order to  who knows the armenian lanuage, but doesn't know the armenian letters can read the text.

----

### ReplaceArm class implementation
```c#
public static class ReplaceArm
{
     
    public static string ReplaceArmText (this string text)
    {
      Console.OutputEncoding = System.Text.Encoding.UTF8;
      Dictionary<string, string> database = new Dictionary<string, string>();
      database.Add("ա", "a");
      database.Add("բ", "b");
      database.Add("գ", "g");
      database.Add("դ", "d");
      database.Add("ե", "e");
      database.Add("զ", "z");
      database.Add("է", "ee");
      database.Add("ը", "yy");
      database.Add("թ", "zh");
      database.Add("ժ", "dj");
      database.Add("ի", "i");
      database.Add("լ", "l");
      database.Add("խ", "kh");
      database.Add("ծ", "ts");
      database.Add("կ", "k");
      database.Add("հ", "h");
      database.Add("ձ", "dz");
      database.Add("ղ", "gh");
      database.Add("ճ", "tc");
      database.Add("մ", "m");
      database.Add("յ", "y");
      database.Add("ն", "n");
      database.Add("շ", "sh");
      database.Add("ո", "w");
      database.Add("չ", "ch");
      database.Add("պ", "p");
      database.Add("ջ", "j");
      database.Add("ռ", "r");
      database.Add("ս", "s");
      database.Add("վ", "v");
      database.Add("տ", "t");
      database.Add("ր", "r");
      database.Add("ց", "c");
      database.Add("ու", "vu");
      database.Add("փ", "ph");
      database.Add("ք", "q");
      database.Add("և", "ev");
      database.Add("օ", "o");
      database.Add("ֆ", "f");

      string result = "";
      bool flag = false;
      for (int i = 0; i < text.Length; i++)
      { if (char.IsUpper(text[i]))
          flag = true;
        foreach (KeyValuePair<string, string> key in database)
        { if (text[i].ToString().ToLower() == key.Key && flag == true)
          {
            result += key.Value.ToUpper();
          }
           if (text[i].ToString() == key.Key)
            result += key.Value;
          if (char.IsNumber(text[i]) || char.IsPunctuation(text[i]) || char.IsWhiteSpace(text[i]))
          { result += text[i].ToString();
            break;
          }    
        }

        flag = false;
      }

      return result;
    }
 }
```
### Description of ReplaceArm class
We declare dictionary and initialise it by the  armenian and english letters. And the when we input the text the program search the armenian letters Equivalent from the dictionary and return them.

### Test 
```c#
string str = "Բարև Հայեր ջան, 1000 բարի, ինչպես եք?";
Console.WriteLine(str.ReplaceArmText());
```

### Result
```
Barev Hayer jan, 1000 bari, inchpes eq?
```

