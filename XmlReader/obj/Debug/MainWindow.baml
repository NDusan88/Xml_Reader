   M S B A M L   `   `   `  ����D  @XmlReader, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:XmlReader	XmlReader  5   	       XmlCitac.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:XmlReader     5   	   -   5          � Title$  
MainWindow��5   	   $	��450��6   $��573.116��6)   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGridClanoviIgraci��5
         
IsReadOnly .    CanUserAddRows .     AlternatingRowBackground
 � ��� �� AlternationCount$ 2��6}      CanUserResizeColumns .     CanUserDeleteRows .     AutoGenerateColumns .  $
��Left=�6�   $��	83,10,0,0q�6  $	��Top=�6+  $	��242��6C  $	��397��6P  ��6�   �� 	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Ime i Prezime��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *
prezimeime+  5      $
 Datum rodjena��6%    6<   �� *datumrodjenja+  5      $
 Broj Telefona��6%    6<   �� *brojtelefona+  5      $
 Adresa��6%    65   �� *adresa+  5      $
 Email��6%    64   �� *email+5      �� 5   
   -   5         ��Name$ 
buttonSave��5      $
��Save��6%   $
��Left=�64   $��
83,271,0,0q�6O   $	��Top=�6c   $��75��6{   6�   5      5      