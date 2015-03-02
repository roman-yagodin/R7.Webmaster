
// This file has been generated by the GUI designer. Do not modify.
namespace R7.Webmaster.Addins.Characters
{
	public partial class CharactersWidget
	{
		private global::Gtk.UIManager UIManager;
		
		private global::Gtk.ToggleAction toggleAppend;
		
		private global::Gtk.Action actionClear;
		
		private global::Gtk.VBox vbox1;
		
		private global::Gtk.Table tableCharacters;
		
		private global::Gtk.Table table1;
		
		private global::Gtk.ToggleButton buttonCopyCharacters;
		
		private global::Gtk.ToggleButton buttonCopyEntities;
		
		private global::Gtk.ToggleButton buttonCopyHexEntities;
		
		private global::Gtk.ToggleButton buttonCopyNumericEntities;
		
		private global::Gtk.ToggleButton buttonCopyUnicode;
		
		private global::Gtk.Entry entryCharacters;
		
		private global::Gtk.Entry entryEntities;
		
		private global::Gtk.Entry entryHexEntities;
		
		private global::Gtk.Entry entryNumericEntities;
		
		private global::Gtk.Entry entryUnicode;
		
		private global::Gtk.Label label1;
		
		private global::Gtk.Label label2;
		
		private global::Gtk.Label label3;
		
		private global::Gtk.Label label4;
		
		private global::Gtk.Label label5;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget R7.Webmaster.Addins.Characters.CharactersWidget
			Stetic.BinContainer w1 = global::Stetic.BinContainer.Attach (this);
			this.UIManager = new global::Gtk.UIManager ();
			global::Gtk.ActionGroup w2 = new global::Gtk.ActionGroup ("Default");
			this.toggleAppend = new global::Gtk.ToggleAction ("toggleAppend", global::Mono.Unix.Catalog.GetString ("Append"), null, "gtk-add");
			this.toggleAppend.IsImportant = true;
			this.toggleAppend.ShortLabel = global::Mono.Unix.Catalog.GetString ("Append");
			w2.Add (this.toggleAppend, null);
			this.actionClear = new global::Gtk.Action ("actionClear", global::Mono.Unix.Catalog.GetString ("Clear"), null, "gtk-clear");
			this.actionClear.ShortLabel = global::Mono.Unix.Catalog.GetString ("Clear");
			w2.Add (this.actionClear, null);
			this.UIManager.InsertActionGroup (w2, 0);
			this.Name = "R7.Webmaster.Addins.Characters.CharactersWidget";
			// Container child R7.Webmaster.Addins.Characters.CharactersWidget.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.tableCharacters = new global::Gtk.Table (((uint)(4)), ((uint)(5)), false);
			this.tableCharacters.Name = "tableCharacters";
			this.tableCharacters.RowSpacing = ((uint)(6));
			this.tableCharacters.ColumnSpacing = ((uint)(6));
			this.vbox1.Add (this.tableCharacters);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.tableCharacters]));
			w3.Position = 0;
			// Container child vbox1.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table (((uint)(5)), ((uint)(3)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.buttonCopyCharacters = new global::Gtk.ToggleButton ();
			this.buttonCopyCharacters.CanFocus = true;
			this.buttonCopyCharacters.Name = "buttonCopyCharacters";
			this.buttonCopyCharacters.UseUnderline = true;
			this.buttonCopyCharacters.Label = global::Mono.Unix.Catalog.GetString ("Copy");
			this.table1.Add (this.buttonCopyCharacters);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1 [this.buttonCopyCharacters]));
			w4.LeftAttach = ((uint)(2));
			w4.RightAttach = ((uint)(3));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.buttonCopyEntities = new global::Gtk.ToggleButton ();
			this.buttonCopyEntities.CanFocus = true;
			this.buttonCopyEntities.Name = "buttonCopyEntities";
			this.buttonCopyEntities.UseUnderline = true;
			this.buttonCopyEntities.Label = global::Mono.Unix.Catalog.GetString ("Copy");
			this.table1.Add (this.buttonCopyEntities);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1 [this.buttonCopyEntities]));
			w5.TopAttach = ((uint)(1));
			w5.BottomAttach = ((uint)(2));
			w5.LeftAttach = ((uint)(2));
			w5.RightAttach = ((uint)(3));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.buttonCopyHexEntities = new global::Gtk.ToggleButton ();
			this.buttonCopyHexEntities.CanFocus = true;
			this.buttonCopyHexEntities.Name = "buttonCopyHexEntities";
			this.buttonCopyHexEntities.UseUnderline = true;
			this.buttonCopyHexEntities.Label = global::Mono.Unix.Catalog.GetString ("Copy");
			this.table1.Add (this.buttonCopyHexEntities);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1 [this.buttonCopyHexEntities]));
			w6.TopAttach = ((uint)(3));
			w6.BottomAttach = ((uint)(4));
			w6.LeftAttach = ((uint)(2));
			w6.RightAttach = ((uint)(3));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.buttonCopyNumericEntities = new global::Gtk.ToggleButton ();
			this.buttonCopyNumericEntities.CanFocus = true;
			this.buttonCopyNumericEntities.Name = "buttonCopyNumericEntities";
			this.buttonCopyNumericEntities.UseUnderline = true;
			this.buttonCopyNumericEntities.Label = global::Mono.Unix.Catalog.GetString ("Copy");
			this.table1.Add (this.buttonCopyNumericEntities);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1 [this.buttonCopyNumericEntities]));
			w7.TopAttach = ((uint)(2));
			w7.BottomAttach = ((uint)(3));
			w7.LeftAttach = ((uint)(2));
			w7.RightAttach = ((uint)(3));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.buttonCopyUnicode = new global::Gtk.ToggleButton ();
			this.buttonCopyUnicode.CanFocus = true;
			this.buttonCopyUnicode.Name = "buttonCopyUnicode";
			this.buttonCopyUnicode.UseUnderline = true;
			this.buttonCopyUnicode.Label = global::Mono.Unix.Catalog.GetString ("Copy");
			this.table1.Add (this.buttonCopyUnicode);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1 [this.buttonCopyUnicode]));
			w8.TopAttach = ((uint)(4));
			w8.BottomAttach = ((uint)(5));
			w8.LeftAttach = ((uint)(2));
			w8.RightAttach = ((uint)(3));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryCharacters = new global::Gtk.Entry ();
			this.entryCharacters.CanFocus = true;
			this.entryCharacters.Name = "entryCharacters";
			this.entryCharacters.IsEditable = true;
			this.entryCharacters.InvisibleChar = '●';
			this.table1.Add (this.entryCharacters);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1 [this.entryCharacters]));
			w9.LeftAttach = ((uint)(1));
			w9.RightAttach = ((uint)(2));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryEntities = new global::Gtk.Entry ();
			this.entryEntities.CanFocus = true;
			this.entryEntities.Name = "entryEntities";
			this.entryEntities.IsEditable = true;
			this.entryEntities.InvisibleChar = '●';
			this.table1.Add (this.entryEntities);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1 [this.entryEntities]));
			w10.TopAttach = ((uint)(1));
			w10.BottomAttach = ((uint)(2));
			w10.LeftAttach = ((uint)(1));
			w10.RightAttach = ((uint)(2));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryHexEntities = new global::Gtk.Entry ();
			this.entryHexEntities.CanFocus = true;
			this.entryHexEntities.Name = "entryHexEntities";
			this.entryHexEntities.IsEditable = true;
			this.entryHexEntities.InvisibleChar = '●';
			this.table1.Add (this.entryHexEntities);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1 [this.entryHexEntities]));
			w11.TopAttach = ((uint)(3));
			w11.BottomAttach = ((uint)(4));
			w11.LeftAttach = ((uint)(1));
			w11.RightAttach = ((uint)(2));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryNumericEntities = new global::Gtk.Entry ();
			this.entryNumericEntities.CanFocus = true;
			this.entryNumericEntities.Name = "entryNumericEntities";
			this.entryNumericEntities.IsEditable = true;
			this.entryNumericEntities.InvisibleChar = '●';
			this.table1.Add (this.entryNumericEntities);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1 [this.entryNumericEntities]));
			w12.TopAttach = ((uint)(2));
			w12.BottomAttach = ((uint)(3));
			w12.LeftAttach = ((uint)(1));
			w12.RightAttach = ((uint)(2));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryUnicode = new global::Gtk.Entry ();
			this.entryUnicode.CanFocus = true;
			this.entryUnicode.Name = "entryUnicode";
			this.entryUnicode.IsEditable = true;
			this.entryUnicode.InvisibleChar = '●';
			this.table1.Add (this.entryUnicode);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table1 [this.entryUnicode]));
			w13.TopAttach = ((uint)(4));
			w13.BottomAttach = ((uint)(5));
			w13.LeftAttach = ((uint)(1));
			w13.RightAttach = ((uint)(2));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 1F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Characters:");
			this.table1.Add (this.label1);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table1 [this.label1]));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.Xalign = 1F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Entity Names:");
			this.table1.Add (this.label2);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table1 [this.label2]));
			w15.TopAttach = ((uint)(1));
			w15.BottomAttach = ((uint)(2));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 1F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Numeric Entities:");
			this.table1.Add (this.label3);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table1 [this.label3]));
			w16.TopAttach = ((uint)(2));
			w16.BottomAttach = ((uint)(3));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.Xalign = 1F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Numeric Entities (hex):");
			this.table1.Add (this.label4);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table1 [this.label4]));
			w17.TopAttach = ((uint)(3));
			w17.BottomAttach = ((uint)(4));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.Xalign = 1F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Unicode Designation:");
			this.table1.Add (this.label5);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table1 [this.label5]));
			w18.TopAttach = ((uint)(4));
			w18.BottomAttach = ((uint)(5));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox1.Add (this.table1);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.table1]));
			w19.Position = 1;
			w19.Expand = false;
			w19.Fill = false;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			w1.SetUiManager (UIManager);
			this.Hide ();
			this.actionClear.Activated += new global::System.EventHandler (this.OnActionClearActivated);
			this.buttonCopyUnicode.Toggled += new global::System.EventHandler (this.OnButtonCopyClicked);
			this.buttonCopyNumericEntities.Toggled += new global::System.EventHandler (this.OnButtonCopyClicked);
			this.buttonCopyHexEntities.Toggled += new global::System.EventHandler (this.OnButtonCopyClicked);
			this.buttonCopyEntities.Toggled += new global::System.EventHandler (this.OnButtonCopyClicked);
			this.buttonCopyCharacters.Toggled += new global::System.EventHandler (this.OnButtonCopyClicked);
		}
	}
}
