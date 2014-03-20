using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

/// <summary>
/// Summary description for LoginClass
/// </summary>
public class LoginClass
{

    CommunityAssistEntities ce = new CommunityAssistEntities();
    string password;
    string username;
    //int PersonKey = 0;


    public LoginClass(string pass, string user)
    {
        //
        // TODO: Add constructor logic here
        //
        password = pass;
        username = user;


    }

    public int ValidateLogin()
    {

        int pk = 0;
        var log = from r in ce.People
                  where r.PersonUsername == username
                  && r.PersonPlainPassword == password
                  select new { r.PersonKey, r.Personpasskey, r.PersonUserPassword };
        int pCode = 0;
        Byte[] pWord=null;
        //int pk = 0;
        int personkey=0;

        foreach (var p in log)
        {
            personkey = (int)p.PersonKey;
            pCode = (int)p.Personpasskey;
            pWord = (Byte[])p.PersonUserPassword;
        }
        PasswordHash ph = new PasswordHash();

        Byte[] newHash = ph.Hashit(password, pCode.ToString());
        //string passString = ConvertBytes(pWord);
        //string newHashString = ConvertBytes(newHash);


        if (pWord.SequenceEqual(newHash)) 
           {
                pk = personkey;
           }
       // if (passString.Equals(newHashString))
       // {
         //   pk = personkey;

      //  }
        return pk;


    }
/*
    private string ConvertBytes(Byte[] encodedBytes)
    {
        //bitconverter is a built in method
        //to convert byte arrays to strings
        string x = BitConverter.ToString(encodedBytes);
        //you need to use a regular expression for the conversion
        Regex rgx = new Regex("[^a-zA-Z0-9]");
        //I add an OX before the string as marker
        //of the number system used
        x = rgx.Replace(x, "");
        return "0x" + x;

    }
 */
}