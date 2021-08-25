﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gotcha.Models
{
    class Rule
    {
        //Atributte/property
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid Maker_Id { get; set; }

        //Relations
        public User User { get; set; }
        public List<RuleRuleSet> RuleRuleSet { get; set; }
    }
}
