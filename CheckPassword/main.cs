// Check CheckPassword
// 주어진 password 문자열이 다음 규칙을 만족하는지 알려주는 CheckPassword(string password)
// 작성하세요.
// 1. 6~15자리까지만 가능
// 2. 연속으로 동일 문자가 나오지 않아야함
// 3. 적어도 하나의 소문자 포함
// 4. 적어도 하나의 대문자 포함
// 5. 적어도 하나의 특수 문자 포함 !@#$%^&*()?/>.<,:;'\|}]{[_~`+="-
// 6. 공백 문자 포함 불가

using System;
using System.Linq;

class Check{

  public bool CheckPassword(string password){
    if (password.Length < 6 || password.Length > 15)
      return false;

    if (password.Contains(" "))
      return false;

    if (!password.Any(char.IsUpper))
      return false;

    if (!password.Any(char.IsLower))
      return false;

    for (int i = 0; i < password.Length - 1; i++)
    {
      if (password[i] == password[i + 1])
        return false;
    }

    string special = @"! @ # $ % ^ & * ( ) ? / > . < , : ; ' \ | } ] { [ _ ~ ` + = - " + "\"";
    string[] specials = special.Split(' ');
    foreach (string s in specials)
    {
      if (password.Contains(s))
        return true;
    }
      return false;

  }

}

class MainClass {

  public static void Main (string[] args) {
    Check cp = new Check();

    Console.WriteLine ( cp.CheckPassword("Abcdefghijk!") == true);
    Console.WriteLine ( cp.CheckPassword("Abcde") == false);
    Console.WriteLine ( cp.CheckPassword("Abccefghijk") == false);
    Console.WriteLine ( cp.CheckPassword("ABCDEFGHIJK!") == false);
    Console.WriteLine ( cp.CheckPassword("abcdefghijk!") == false);
    Console.WriteLine ( cp.CheckPassword("Abcdefghijk") == false);
    Console.WriteLine ( cp.CheckPassword("Abcdefghijk !") == false);
    
    Console.WriteLine ( cp.CheckPassword("Abcdefdfdfdghijk!") == false);
    Console.WriteLine ( cp.CheckPassword("") == false);
    Console.WriteLine ( cp.CheckPassword("Abcdefghijk\\") == true);
    
    // string special = @"! @ # $ % ^ & * ( ) ? / > . < , : ; ' \ | } ] { [ _ ~ ` + = - " + "\"";
    // string[] specials = special.Split(' ');
    // foreach (string s in specials)
    //   Console.Write(s);
  }
}