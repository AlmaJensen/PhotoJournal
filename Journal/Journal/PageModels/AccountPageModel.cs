﻿using FreshMvvm;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journal.PageModels
{
    [ImplementPropertyChanged]
    public class AccountPageModel : FreshBasePageModel
    {
		public string MainText { get; set; } = "Hello account page";
	}
}
