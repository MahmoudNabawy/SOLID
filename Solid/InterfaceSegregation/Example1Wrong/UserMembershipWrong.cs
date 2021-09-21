using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    //A client should never be forced to implement an interface that it doesn’t use, 
    //or clients shouldn’t be forced to depend on methods they do not use.

    //Not achieve  Interface Segregation because if we have page for register and page for login,
    //we not need to get (login, logout, forgetPassword) in register page
    //so we can split this interface into small interfaces with contain main functuionality
     
    public interface UserMembershipWrong
    {
        User login(String username, String password);
        void logout(User user);
        void register(String username, String password, String phone);
        void forgetPassword(String username);
    }
}

