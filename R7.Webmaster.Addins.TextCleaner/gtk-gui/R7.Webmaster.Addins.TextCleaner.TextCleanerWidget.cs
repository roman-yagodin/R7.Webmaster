
// This file has been generated by the GUI designer. Do not modify.
namespace R7.Webmaster.Addins.TextCleaner
{
	public partial class TextCleanerWidget
	{
		private global::Gtk.UIManager UIManager;
		
		private global::Gtk.Action actionProcess;
		
		private global::Gtk.ToggleAction toggleAutoCopy;
		
		private global::Gtk.RadioAction radioCopyText;
		
		private global::Gtk.RadioAction radioCopyHtml;
		
		private global::Gtk.RadioAction radioCopyActiveTab;
		
		private global::Gtk.VBox vbox1;
		
		private global::Gtk.HBox hbox4;
		
		private global::Gtk.VBox vbox2;
		
		private global::Gtk.Notebook notebook1;
		
		private global::Gtk.ScrolledWindow GtkScrolledWindow1;
		
		private global::Gtk.TextView txvResult;
		
		private global::Gtk.Label label3;
		
		private global::Gtk.ScrolledWindow GtkScrolledWindow2;
		
		private global::Gtk.TextView textviewText;
		
		private global::Gtk.Label label2;
		
		private global::Gtk.Alignment alignment4;
		
		private global::Gtk.Alignment GtkAlignment7;
		
		private global::Gtk.Table table1;
		
		private global::Gtk.Alignment alignment2;
		
		private global::Gtk.Table tableClearTablesOptions;
		
		private global::Gtk.ComboBox comboWidthUnits;
		
		private global::Gtk.Entry entryTableClass;
		
		private global::Gtk.Label label1;
		
		private global::Gtk.Label label4;
		
		private global::Gtk.SpinButton spinTableWidth;
		
		private global::Gtk.CheckButton chkClearTables;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget R7.Webmaster.Addins.TextCleaner.TextCleanerWidget
			Stetic.BinContainer w1 = global::Stetic.BinContainer.Attach (this);
			this.UIManager = new global::Gtk.UIManager ();
			global::Gtk.ActionGroup w2 = new global::Gtk.ActionGroup ("Default");
			this.actionProcess = new global::Gtk.Action ("actionProcess", global::Mono.Unix.Catalog.GetString ("_Process"), null, "gtk-media-play");
			this.actionProcess.IsImportant = true;
			this.actionProcess.ShortLabel = global::Mono.Unix.Catalog.GetString ("_Process");
			w2.Add (this.actionProcess, null);
			this.toggleAutoCopy = new global::Gtk.ToggleAction ("toggleAutoCopy", global::Mono.Unix.Catalog.GetString ("_Auto Copy"), null, "gtk-copy");
			this.toggleAutoCopy.Active = true;
			this.toggleAutoCopy.ShortLabel = global::Mono.Unix.Catalog.GetString ("_Auto Copy");
			w2.Add (this.toggleAutoCopy, null);
			this.radioCopyText = new global::Gtk.RadioAction ("radioCopyText", global::Mono.Unix.Catalog.GetString ("Copy Text"), null, null, 0);
			this.radioCopyText.Group = new global::GLib.SList (global::System.IntPtr.Zero);
			this.radioCopyText.ShortLabel = global::Mono.Unix.Catalog.GetString ("Copy Text");
			w2.Add (this.radioCopyText, null);
			this.radioCopyHtml = new global::Gtk.RadioAction ("radioCopyHtml", global::Mono.Unix.Catalog.GetString ("Copy HTML"), null, null, 0);
			this.radioCopyHtml.Group = this.radioCopyText.Group;
			this.radioCopyHtml.ShortLabel = global::Mono.Unix.Catalog.GetString ("Copy HTML");
			w2.Add (this.radioCopyHtml, null);
			this.radioCopyActiveTab = new global::Gtk.RadioAction ("radioCopyActiveTab", global::Mono.Unix.Catalog.GetString ("Copy Active Tab"), null, null, 0);
			this.radioCopyActiveTab.Group = this.radioCopyHtml.Group;
			this.radioCopyActiveTab.ShortLabel = global::Mono.Unix.Catalog.GetString ("Copy Active Tab");
			w2.Add (this.radioCopyActiveTab, null);
			this.UIManager.InsertActionGroup (w2, 0);
			this.Name = "R7.Webmaster.Addins.TextCleaner.TextCleanerWidget";
			// Container child R7.Webmaster.Addins.TextCleaner.TextCleanerWidget.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.notebook1 = new global::Gtk.Notebook ();
			this.notebook1.CanFocus = true;
			this.notebook1.Name = "notebook1";
			this.notebook1.CurrentPage = 1;
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.txvResult = new global::Gtk.TextView ();
			this.txvResult.HeightRequest = 100;
			this.txvResult.CanFocus = true;
			this.txvResult.Name = "txvResult";
			this.txvResult.WrapMode = ((global::Gtk.WrapMode)(3));
			this.GtkScrolledWindow1.Add (this.txvResult);
			this.notebook1.Add (this.GtkScrolledWindow1);
			// Notebook tab
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("HTML");
			this.notebook1.SetTabLabel (this.GtkScrolledWindow1, this.label3);
			this.label3.ShowAll ();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.GtkScrolledWindow2 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow2.Name = "GtkScrolledWindow2";
			// Container child GtkScrolledWindow2.Gtk.Container+ContainerChild
			this.textviewText = new global::Gtk.TextView ();
			this.textviewText.CanFocus = true;
			this.textviewText.Name = "textviewText";
			this.textviewText.WrapMode = ((global::Gtk.WrapMode)(3));
			this.GtkScrolledWindow2.Add (this.textviewText);
			this.notebook1.Add (this.GtkScrolledWindow2);
			global::Gtk.Notebook.NotebookChild w6 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.GtkScrolledWindow2]));
			w6.Position = 1;
			// Notebook tab
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Plain text");
			this.notebook1.SetTabLabel (this.GtkScrolledWindow2, this.label2);
			this.label2.ShowAll ();
			this.vbox2.Add (this.notebook1);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.notebook1]));
			w7.Position = 0;
			this.hbox4.Add (this.vbox2);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.vbox2]));
			w8.Position = 0;
			// Container child hbox4.Gtk.Box+BoxChild
			this.alignment4 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment4.Name = "alignment4";
			this.alignment4.RightPadding = ((uint)(5));
			this.alignment4.BottomPadding = ((uint)(5));
			// Container child alignment4.Gtk.Container+ContainerChild
			this.GtkAlignment7 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment7.Name = "GtkAlignment7";
			this.GtkAlignment7.LeftPadding = ((uint)(12));
			this.GtkAlignment7.TopPadding = ((uint)(4));
			// Container child GtkAlignment7.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table (((uint)(2)), ((uint)(1)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.alignment2 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment2.Name = "alignment2";
			this.alignment2.LeftPadding = ((uint)(24));
			this.alignment2.RightPadding = ((uint)(10));
			// Container child alignment2.Gtk.Container+ContainerChild
			this.tableClearTablesOptions = new global::Gtk.Table (((uint)(2)), ((uint)(3)), false);
			this.tableClearTablesOptions.Sensitive = false;
			this.tableClearTablesOptions.Name = "tableClearTablesOptions";
			this.tableClearTablesOptions.RowSpacing = ((uint)(6));
			this.tableClearTablesOptions.ColumnSpacing = ((uint)(6));
			// Container child tableClearTablesOptions.Gtk.Table+TableChild
			this.comboWidthUnits = global::Gtk.ComboBox.NewText ();
			this.comboWidthUnits.AppendText (global::Mono.Unix.Catalog.GetString ("%"));
			this.comboWidthUnits.AppendText (global::Mono.Unix.Catalog.GetString ("px"));
			this.comboWidthUnits.AppendText (global::Mono.Unix.Catalog.GetString ("pc"));
			this.comboWidthUnits.AppendText (global::Mono.Unix.Catalog.GetString ("em"));
			this.comboWidthUnits.AppendText (global::Mono.Unix.Catalog.GetString ("ex"));
			this.comboWidthUnits.AppendText (global::Mono.Unix.Catalog.GetString ("in"));
			this.comboWidthUnits.AppendText (global::Mono.Unix.Catalog.GetString ("pt"));
			this.comboWidthUnits.AppendText (global::Mono.Unix.Catalog.GetString ("cm"));
			this.comboWidthUnits.AppendText (global::Mono.Unix.Catalog.GetString ("mm"));
			this.comboWidthUnits.Name = "comboWidthUnits";
			this.comboWidthUnits.Active = 0;
			this.tableClearTablesOptions.Add (this.comboWidthUnits);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.tableClearTablesOptions [this.comboWidthUnits]));
			w9.TopAttach = ((uint)(1));
			w9.BottomAttach = ((uint)(2));
			w9.LeftAttach = ((uint)(2));
			w9.RightAttach = ((uint)(3));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableClearTablesOptions.Gtk.Table+TableChild
			this.entryTableClass = new global::Gtk.Entry ();
			this.entryTableClass.TooltipMarkup = "CSS class for cleaned table";
			this.entryTableClass.CanFocus = true;
			this.entryTableClass.Name = "entryTableClass";
			this.entryTableClass.Text = global::Mono.Unix.Catalog.GetString ("data");
			this.entryTableClass.IsEditable = true;
			this.entryTableClass.WidthChars = 12;
			this.entryTableClass.InvisibleChar = '●';
			this.tableClearTablesOptions.Add (this.entryTableClass);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.tableClearTablesOptions [this.entryTableClass]));
			w10.LeftAttach = ((uint)(1));
			w10.RightAttach = ((uint)(3));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableClearTablesOptions.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 1F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("CSS class:");
			this.tableClearTablesOptions.Add (this.label1);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.tableClearTablesOptions [this.label1]));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableClearTablesOptions.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.Xalign = 1F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Width:");
			this.tableClearTablesOptions.Add (this.label4);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.tableClearTablesOptions [this.label4]));
			w12.TopAttach = ((uint)(1));
			w12.BottomAttach = ((uint)(2));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableClearTablesOptions.Gtk.Table+TableChild
			this.spinTableWidth = new global::Gtk.SpinButton (0, 10000, 1);
			this.spinTableWidth.TooltipMarkup = "Width in % for cleaned table";
			this.spinTableWidth.CanFocus = true;
			this.spinTableWidth.Name = "spinTableWidth";
			this.spinTableWidth.Adjustment.PageIncrement = 10;
			this.spinTableWidth.ClimbRate = 10;
			this.spinTableWidth.Numeric = true;
			this.spinTableWidth.SnapToTicks = true;
			this.spinTableWidth.Value = 100;
			this.tableClearTablesOptions.Add (this.spinTableWidth);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.tableClearTablesOptions [this.spinTableWidth]));
			w13.TopAttach = ((uint)(1));
			w13.BottomAttach = ((uint)(2));
			w13.LeftAttach = ((uint)(1));
			w13.RightAttach = ((uint)(2));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			this.alignment2.Add (this.tableClearTablesOptions);
			this.table1.Add (this.alignment2);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table1 [this.alignment2]));
			w15.TopAttach = ((uint)(1));
			w15.BottomAttach = ((uint)(2));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.chkClearTables = new global::Gtk.CheckButton ();
			this.chkClearTables.CanFocus = true;
			this.chkClearTables.Name = "chkClearTables";
			this.chkClearTables.Label = global::Mono.Unix.Catalog.GetString ("Clear tables");
			this.chkClearTables.DrawIndicator = true;
			this.chkClearTables.UseUnderline = true;
			this.table1.Add (this.chkClearTables);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table1 [this.chkClearTables]));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			this.GtkAlignment7.Add (this.table1);
			this.alignment4.Add (this.GtkAlignment7);
			this.hbox4.Add (this.alignment4);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.alignment4]));
			w19.Position = 1;
			w19.Expand = false;
			w19.Fill = false;
			this.vbox1.Add (this.hbox4);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox4]));
			w20.Position = 0;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			w1.SetUiManager (UIManager);
			this.Hide ();
			this.actionProcess.Activated += new global::System.EventHandler (this.OnActionProcessActivated);
			this.toggleAutoCopy.Toggled += new global::System.EventHandler (this.OnToggleAutoCopyToggled);
			this.radioCopyText.Activated += new global::System.EventHandler (this.OnRadioCopyActivated);
			this.radioCopyHtml.Activated += new global::System.EventHandler (this.OnRadioCopyActivated);
			this.radioCopyActiveTab.Activated += new global::System.EventHandler (this.OnRadioCopyActivated);
			this.chkClearTables.Toggled += new global::System.EventHandler (this.OnChkClearTablesToggled);
		}
	}
}
