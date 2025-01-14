﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zimmers.core.Entities;

namespace zimmers.core.Interfaces.IService
{
    public interface ICleanerService
    {
        public IEnumerable<Cleaner> Get();
        public Cleaner? GetById(int id);
        public Cleaner Add(Cleaner c);
        public Cleaner Update(int id, Cleaner c);
        public bool Delete(int id);
    }
}
