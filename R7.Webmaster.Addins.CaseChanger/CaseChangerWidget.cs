﻿//
//  CaseChangerWidget.cs
//
//  Author:
//       Roman M. Yagodin <roman.yagodin@gmail.com>
//
//  Copyright (c) 2014 Roman M. Yagodin
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using Mono.Addins;
using R7.Webmaster.Core;
using R7.Webmaster.Addins.Root;

namespace R7.Webmaster.Addins.CaseChanger
{
	[System.ComponentModel.ToolboxItem (true)]
	[Extension(typeof(IWidgetAddin))]
	public partial class CaseChangerWidget : Gtk.Bin, ICaseChangerView, ITextInputWidgetAddin
	{
		private CaseChangerModel Model;

		public CaseChangerWidget ()
		{
			this.Build ();

			Model = new CaseChangerModel ();

			radiobutton4.Active = true;
		}

		#region ITextInputWidgetAddin implementation

		public Gtk.Widget Instance { get { return this; } }

		public Gtk.Widget FocusWidget { get { return entryResult1; } }

		public string Label { get { return "Case Changer"; } }

		public string SafeName { get { return "casechanger"; } }

		public ITextInputWidgetAddinHost Host { get; set; }

		public EventHandler OnInputTextChanged 
		{ 
			get { return OnInputTextChangedInternal; } 
		}

		public TextInputAction SupportedActions 
		{
			get { return TextInputAction.Paste | TextInputAction.AutoProcess; }
		}

		public bool IsActive { get; set; }

		public string Icon 
		{ 
			get { return Gtk.Stock.SpellCheck; } 
		}
	
		public List<Gtk.ToolItem> ToolItems
		{
			get 
			{ 
				return new List<Gtk.ToolItem> () {
					(Gtk.ToolItem) actionProcess.CreateToolItem ()
				};
			}
		}

		#endregion

		protected void OnInputTextChangedInternal (object sender, EventArgs e)
		{
			if (IsActive && Host.AutoProcess)
				Process ();
		}

		protected void Process ()
		{
			// All caps
			entryResult1.Text = Host.InputText.ToUpper();

			// All stroke
			entryResult2.Text = Host.InputText.ToLower();

			// Invert case
			entryResult3.Text = Model.InvertedCase (Host.InputText);

			// Sentence case
			entryResult4.Text = Model.SentenceCase (Host.InputText);

			// Word first letter to upper case
			entryResult5.Text = Model.WordFirstLetterUpperCase (Host.InputText);

			// copy results to clipboard
			if (radiobutton1.Active)
				Clipboard.Text = entryResult1.Text;
			else if (radiobutton2.Active)
				Clipboard.Text = entryResult2.Text;
			else if (radiobutton3.Active)
				Clipboard.Text = entryResult3.Text;
			else if (radiobutton4.Active)
				Clipboard.Text = entryResult4.Text;
			else if (radiobutton5.Active)
				Clipboard.Text = entryResult5.Text;
		}

		protected void OnActionProcessActivated (object sender, EventArgs e)
		{
			Process ();
		}

		// TODO: Implement in the host application
		/* 
		protected void OnActionPasteActivated (object sender, EventArgs e)
		{
			entrySource.Text = Clipboard.Text;
			Process ();
		}
		*/

		protected void OnButtonCopy1Clicked (object sender, EventArgs e)
		{
			Clipboard.Text = entryResult1.Text;
		}

		protected void OnButtonCopy2Clicked (object sender, EventArgs e)
		{
			Clipboard.Text = entryResult2.Text;
		}

		protected void OnButtonCopy3Clicked (object sender, EventArgs e)
		{
			Clipboard.Text = entryResult3.Text;
		}

		protected void OnButtonCopy4Clicked (object sender, EventArgs e)
		{
			Clipboard.Text = entryResult4.Text;
		}

		protected void OnButtonCopy5Clicked (object sender, EventArgs e)
		{
			Clipboard.Text = entryResult5.Text;
		}

		/*
		protected void OnEntrySourceChanged (object sender, EventArgs e)
		{
			Process ();
		}*/
	}
}

