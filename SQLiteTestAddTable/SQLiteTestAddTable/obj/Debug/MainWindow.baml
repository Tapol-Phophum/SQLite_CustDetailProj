   M S B A M L   `   `   `  ����M  ISQLiteTestAddTable, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:SQLiteTestAddTableSQLiteTestAddTable  5   	   #    SQLiteTestAddTable.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:SQLiteTestAddTable     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ txtName��5
      $
��Left=�6#   $��35��6>   $��205,155,0,0q�6J    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��320��6�   $��16(�6�   �� 5   
   -   5        $ txtLastName��5      $
��Left=�6'   $��35��6B   $��205,200,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��320��6�   $��16(�6�   �� 5   
   -   5        $ txtEmail��5      $
��Left=�6$   $��35��6?   $��205,255,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��320��6�   $��16(�6�   �� 5   
   -   5         ��Name$ addBtn��5      $��	 New Item��6!   $
��Left=�65   $��35��6P   $��550,105,0,0q�6\   $	��Top=�6q   $	��140��6�   $��16(�6�   $��Century)�6�   ���	#FFADF62E6�   �� 5   
   -   5        $ editBtn��5      $��	Edit Item��6"   $
��Left=�66   $��35��6Q   $��550,155,0,0q�6]   $	��Top=�6r   $	��140��6�   $��16(�6�   $��Century)�6�   ���	#FFE470576�   �� 5   
   -   5        $ 	deleteBtn��5      $��Delete Item��6$   $
��Left=�6:   $��35��6U   $��550,205,0,0q�6a   $	��Top=�6v   $	��140��6�   $��16(�6�   $��Century)�6�   ���	#FFF12F0E6�   �� 5   
   -   5        $ 
showMsgBtn��5      $��Message Box Show��6%   $
��Left=�6@   $��35��6[   $��550,255,0,0q�6g   $	��Top=�6|   $	��140��6�   $��14(�6�   $��Century)�6�   ���	#FF1ABDAF6�   �� 5   
   -   5        $ txtID��5      $
��Left=�6!   $��35��6<   $��205,110,0,0q�6H   $
 Wrap=�6]   $	��Top=�6q   $	��205��6�   $��16(�6�   �� 5   
   -	   5         ��Name$ 	lblCustID��5      $��Customer ID��6#   $
��Left=�69   $��30��6T   $��
80,110,0,0q�6`   $	��Top=�6t   $��95��6�   $��14(�6�   �� 5   
   -
   5        $ lblName��5      $��
First Name��6!   $
��Left=�66   $��30��6Q   $��
80,160,0,0q�6]   $	��Top=�6q   $��95��6�   $��14(�6�   �� 5   
   -   5        $ lblLastName��5      $��	Last Name��6%   $
��Left=�69   $��30��6T   $��
80,200,0,0q�6`   $	��Top=�6t   $��95��6�   $��14(�6�   �� 5   
   -   5        $ lblEmail��5      $��E-Mail��6"   $
��Left=�63   $��30��6N   $��
80,260,0,0q�6Z   $	��Top=�6n   $��95��6�   $��14(�6�   5      5      