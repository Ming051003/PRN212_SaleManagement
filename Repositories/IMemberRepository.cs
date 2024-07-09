﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Models;




namespace Repositories
{
    public interface IMemberRepository
    {
        Member GetMemberById(int memberID);
        Member GetMemberByEmail(string email);

        Member CheckLogin(string email, string password);
    }
}