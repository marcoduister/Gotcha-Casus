﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gotcha.Models
{
    class Word
    {

        //Atributte/property
        public Guid Id { get; set; }
        public string Content { get; set; }
        public Guid Maker_Id { get; set; }

        //Relations
        public User User { get; set; }
        public List<WordWordset> WordWordset { get; set; }
       
    }
}
