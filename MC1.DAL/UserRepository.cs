﻿using System.Collections.Generic;
using System.IO;
using MC1.BO;

namespace MC1.DAL
{
    public class UserRepository :  BaseRepository<User> 

    {
        public UserRepository() : base()
        {
            FileInfo fileInfo = new FileInfo(PATH);
            if (!fileInfo.Exists || fileInfo.Length == 0)
            {
                User user = new User("admin@admin.net");
                Add(user);
            }
        }

        public List<User> FindByName(string name)
        {
            List<User> list = new List<User>();
            foreach (var data in datas)
                if (data.Fullname.ToLower().Contains(name.ToLower()))
                    list.Add(data);
            return new List<User>(list);
        }

        public List<User> FindByEmail(string email)
        {
            List<User> list = new List<User>();
            foreach (var data in datas)
                if (data.Fullname.ToLower().Contains(email.ToLower()))
                    list.Add(data);
            return new List<User>(list);
        }
    }
}
