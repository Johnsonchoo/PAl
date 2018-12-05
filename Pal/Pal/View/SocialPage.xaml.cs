﻿using Pal.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pal.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SocialPage : ContentPage
	{
        SocialViewModel VM;

		public SocialPage ()
		{
			InitializeComponent ();
            VM = new SocialViewModel();
            BindingContext = VM;
		}
	}
}