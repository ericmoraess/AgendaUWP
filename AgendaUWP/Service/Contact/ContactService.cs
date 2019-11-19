﻿using Data.DataService;
using Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contact
{
    public class ContactService : IContactService<Model.Contact>
    {
        IDataStorage dataStorage;

        public ContactService(IDataStorage dataStorage)
        {
            this.dataStorage = dataStorage;
        }

        public void Add(Model.Contact contact)
        {
            dataStorage.Save(contact);
        }
    }
}
